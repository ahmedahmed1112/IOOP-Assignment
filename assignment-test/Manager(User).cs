using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data; // For DataTable
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_test
{
      public class Manager
    {
        public string ManagerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        private readonly string _connStr =
    @"Data Source=LAPTOP-7LLUAD3U;Initial Catalog=BBBBADR;Integrated Security=True;";

        private static string NextId(SqlConnection conn, string table, string idCol, string prefix, int width)
        {
            using (var cmd = new SqlCommand(
                $"SELECT TOP 1 {idCol} FROM {table} WHERE {idCol} LIKE @p + '%' ORDER BY {idCol} DESC", conn))
            {
                cmd.Parameters.AddWithValue("@p", prefix);
                var val = cmd.ExecuteScalar();
                int n = 0;

                if (val != null && val != DBNull.Value)
                {
                    var s = val.ToString();
                    if (!string.IsNullOrEmpty(s) && s.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    {
                        int.TryParse(s.Substring(prefix.Length), out n);
                    }
                }

                return prefix + (n + 1).ToString(new string('0', width)); // e.g. RE03 / MS05
            }
        }



        /// <summary>
        /// Task 1: Manage user accounts (Reception & Maintenance).
        /// operation: "add" or "delete".
        /// For "add": provide fullName, email, password, phoneNumber, role ("reception"|"maintenance").
        /// For "delete": provide userId only.
        /// Returns: new user_id when adding; 0 otherwise.
        /// </summary>
        public int ManageStaffAccount(
            string operation,
    int? userId = null,
    string fullName = null,
    string email = null,
    string password = null,
    string phoneNumber = null,
    string role = null
)
        {
            if (string.IsNullOrWhiteSpace(operation))
                throw new ArgumentException("Operation is required.");

            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();

                if (operation.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(fullName) ||
                        string.IsNullOrWhiteSpace(email) ||
                        string.IsNullOrWhiteSpace(password) ||
                        string.IsNullOrWhiteSpace(phoneNumber) ||
                        string.IsNullOrWhiteSpace(role))
                        throw new ArgumentException("All staff fields are required for add.");

                    var normalizedRole = role.Trim().ToLowerInvariant();
                    if (normalizedRole != "reception" && normalizedRole != "maintenance")
                        throw new ArgumentException("Role must be 'reception' or 'maintenance'.");

                    string sql;
                    if (normalizedRole == "maintenance")
                    {
                        sql = @"
                    INSERT INTO MaintenanceStaff (FirstName, LastName, Email, Phone, Password)
                    OUTPUT INSERTED.MaintenanceID
                    VALUES (@fname, @lname, @mail, @phone, @pass);";
                    }
                    else // reception
                    {
                        sql = @"
                    INSERT INTO Reception (FirstName, LastName, Email, Phone, Password)
                    OUTPUT INSERTED.ReceptionID
                    VALUES (@fname, @lname, @mail, @phone, @pass);";
                    }

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        // Split fullName into first/last if possible
                        var parts = fullName.Split(' ');
                        string firstName = parts.Length > 0 ? parts[0] : fullName;
                        string lastName = parts.Length > 1 ? parts[1] : "";

                        cmd.Parameters.AddWithValue("@fname", firstName);
                        cmd.Parameters.AddWithValue("@lname", lastName);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@pass", password);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                else if (operation.Equals("delete", StringComparison.OrdinalIgnoreCase))
                {
                    if (userId == null) throw new ArgumentNullException(nameof(userId));

                    // Delete from both tables depending on role
                    const string sql = @"
                DELETE FROM MaintenanceStaff WHERE MaintenanceID = @id;
                DELETE FROM Reception WHERE ReceptionID = @id;";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId.Value);
                        var rows = cmd.ExecuteNonQuery();
                        if (rows == 0) throw new Exception("No matching staff user found.");
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException("Operation must be 'add' or 'delete'.");
                }
            }
        }

        public int AddReception(string firstName, string lastName, string email, string phone, string password)
        {
            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();
                var newId = NextId(conn, "Reception", "ReceptionID", "RE", 2);

                const string sql = @"
INSERT INTO Reception (ReceptionID, FirstName, LastName, Email, Phone, Password)
VALUES (@id, @fn, @ln, @em, @ph, @pw);";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@fn", firstName);
                    cmd.Parameters.AddWithValue("@ln", lastName);
                    cmd.Parameters.AddWithValue("@em", email);
                    cmd.Parameters.AddWithValue("@ph", phone);
                    cmd.Parameters.AddWithValue("@pw", password);
                    return cmd.ExecuteNonQuery(); // 1 on success
                }
            }
        }





        /// <summary>
        /// Task 2: Manage facilities for universities.
        /// operation: "add" | "edit" | "delete".
        /// Returns: new facility_id when adding; 0 for edit/delete.
        /// </summary>
        public int ManageFacility(
            string operation,
            int? facilityId = null,
            int? universityId = null,
            string facilityType = null,
            decimal? rate = null,
            string description = null)
        {
            if (string.IsNullOrWhiteSpace(operation))
                throw new ArgumentException("Operation is required.");

            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();

                if (operation.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    const string sql = @"
                        INSERT INTO facilities (university_id, facility_type, rate, description)
                        OUTPUT INSERTED.facility_id
                        VALUES (@univ, @type, @rate, @desc);";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@univ", universityId);
                        cmd.Parameters.AddWithValue("@type", facilityType);
                        cmd.Parameters.AddWithValue("@rate", rate);
                        cmd.Parameters.AddWithValue("@desc", (object)description ?? DBNull.Value);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                else if (operation.Equals("edit", StringComparison.OrdinalIgnoreCase))
                {
                    const string sql = @"
                        UPDATE facilities
                        SET university_id = @univ,
                            facility_type = @type,
                            rate = @rate,
                            description = @desc
                        WHERE facility_id = @id;";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", facilityId);
                        cmd.Parameters.AddWithValue("@univ", universityId);
                        cmd.Parameters.AddWithValue("@type", facilityType);
                        cmd.Parameters.AddWithValue("@rate", rate);
                        cmd.Parameters.AddWithValue("@desc", (object)description ?? DBNull.Value);
                        var rows = cmd.ExecuteNonQuery();
                        if (rows == 0) throw new Exception("Facility not found.");
                        return 0;
                    }
                }
                else if (operation.Equals("delete", StringComparison.OrdinalIgnoreCase))
                {
                    const string sql = @"DELETE FROM facilities WHERE facility_id = @id;";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", facilityId);
                        var rows = cmd.ExecuteNonQuery();
                        if (rows == 0) throw new Exception("Facility not found.");
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException("Operation must be 'add', 'edit', or 'delete'.");
                }
            }
        }

        /// <summary>
        /// Task 3: Assign maintenance schedule + staff for a facility.
        /// Returns: new schedule_id.
        /// </summary>
        public int AssignMaintenanceSchedule(
            int facilityId,
            int staffUserId,
            DateTime scheduledAt,
            string frequency,     // e.g., "Weekly", "Monthly"
            string notes,
            int managerId
            )
        {
            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();

                const string sql = @"
                    INSERT INTO maintenance_schedules
                        (facility_id, staff_id, scheduled_at, frequency, notes, status, created_by)
                    OUTPUT INSERTED.schedule_id
                    VALUES
                        (@facilityId, @staffId, @scheduledAt, @frequency, @notes, 'Scheduled', @managerId);";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@facilityId", facilityId);
                    cmd.Parameters.AddWithValue("@staffId", staffUserId);
                    cmd.Parameters.AddWithValue("@scheduledAt", scheduledAt);
                    cmd.Parameters.AddWithValue("@frequency", frequency);
                    cmd.Parameters.AddWithValue("@notes", (object)notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Task 4: View/approve equipment requests (approve OR reject).
        /// decision: "Approved" | "Rejected".
        /// </summary>
        public void ReviewEquipmentRequest(
            int requestId,
            int managerId,
            string decision,
            string managerNote = null)
        {
            if (!(decision.Equals("Approved", StringComparison.OrdinalIgnoreCase) ||
                  decision.Equals("Rejected", StringComparison.OrdinalIgnoreCase)))
                throw new ArgumentException("Decision must be 'Approved' or 'Rejected'.");

            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();

                const string sql = @"
                    UPDATE equipment_requests
                    SET status = @decision,
                        manager_id = @managerId,
                        decided_at = @now,
                        manager_note = @note
                    WHERE request_id = @requestId AND status = 'Pending';";

                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@decision", decision);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    cmd.Parameters.AddWithValue("@now", DateTime.Now);
                    cmd.Parameters.AddWithValue("@note", (object)managerNote ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@requestId", requestId);

                    var rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                        throw new Exception("Request not found or already reviewed.");
                }
            }
        }
        public int ManageStaffAccount(
    string operation,
    string userId = null,        // string because your IDs are like "R01", "MS01"
    string fullName = null,
    string email = null,
    string password = null,
    string phoneNumber = null,
    string role = null)
        {
            if (string.IsNullOrWhiteSpace(operation))
                throw new ArgumentException("Operation is required.");

            using (var conn = new SqlConnection(_connStr))
            {
                conn.Open();






                if (string.Equals(operation, "add", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(fullName) ||
                        string.IsNullOrWhiteSpace(email) ||
                        string.IsNullOrWhiteSpace(password) ||
                        string.IsNullOrWhiteSpace(phoneNumber) ||
                        string.IsNullOrWhiteSpace(role))
                        throw new ArgumentException("All staff fields are required for add.");

                    var normalizedRole = role.Trim().ToLowerInvariant();
                    if (normalizedRole != "reception" && normalizedRole != "maintenance")
                        throw new ArgumentException("Role must be 'reception' or 'maintenance'.");

                    if (normalizedRole == "reception")
                    {
                        // ReceptionID is NOT identity in your DB -> generate like R01, R02...
                        var newId = GenerateNextId(conn, "Reception", "ReceptionID", "R", 2);

                        var sql = @"INSERT INTO Reception (ReceptionID, FirstName, LastName, Email, Phone, Password)
                            VALUES (@id, @fn, @ln, @mail, @phone, @pass);";

                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            var names = SplitName(fullName); // "John Smith" -> ("John","Smith")
                            cmd.Parameters.AddWithValue("@id", newId);
                            cmd.Parameters.AddWithValue("@fn", names.Item1 ?? "");
                            cmd.Parameters.AddWithValue("@ln", names.Item2 ?? "");
                            cmd.Parameters.AddWithValue("@mail", (object)email ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@phone", (object)phoneNumber ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@pass", password);
                            cmd.ExecuteNonQuery();
                        }
                        return 1;
                    }
                    else // maintenance
                    {
                        var newId = GenerateNextId(conn, "MaintenanceStaff", "MaintenanceID", "MS", 2);

                        var sql = @"INSERT INTO MaintenanceStaff (MaintenanceID, FirstName, LastName, Email, Phone, Password)
                            VALUES (@id, @fn, @ln, @mail, @phone, @pass);";

                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            var names = SplitName(fullName);
                            cmd.Parameters.AddWithValue("@id", newId);
                            cmd.Parameters.AddWithValue("@fn", names.Item1 ?? "");
                            cmd.Parameters.AddWithValue("@ln", names.Item2 ?? "");
                            cmd.Parameters.AddWithValue("@mail", (object)email ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@phone", (object)phoneNumber ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@pass", password);
                            cmd.ExecuteNonQuery();
                        }
                        return 1;
                    }
                }
                else if (string.Equals(operation, "delete", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(userId))
                        throw new ArgumentNullException("userId");

                    // Decide table by the ID prefix (R.. -> Reception, MS.. -> Maintenance)
                    string sql;
                    if (userId.StartsWith("R", StringComparison.OrdinalIgnoreCase))
                        sql = "DELETE FROM Reception WHERE ReceptionID = @id;";
                    else if (userId.StartsWith("MS", StringComparison.OrdinalIgnoreCase))
                        sql = "DELETE FROM MaintenanceStaff WHERE MaintenanceID = @id;";
                    else
                        throw new ArgumentException("Unknown id format.");

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        var rows = cmd.ExecuteNonQuery();
                        if (rows == 0) throw new Exception("No matching staff user found.");
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException("Operation must be 'add' or 'delete'.");
                }
            }
        }

        // Helpers (C# 7.3-friendly)
        private static Tuple<string, string> SplitName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return Tuple.Create("", "");
            var parts = fullName.Trim().Split(new[] { ' ' }, 2);
            if (parts.Length == 1) return Tuple.Create(parts[0], "");
            return Tuple.Create(parts[0], parts[1]);
        }

        private static string GenerateNextId(SqlConnection conn, string table, string column, string prefix, int digits)
        {
            var sql = $"SELECT TOP(1) {column} FROM {table} " +
                      $"WHERE {column} LIKE @p + '%' ORDER BY {column} DESC;";
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@p", prefix);
                var last = cmd.ExecuteScalar() as string;
                var next = 1;
                if (!string.IsNullOrEmpty(last) && last.Length > prefix.Length)
                {
                    int n;
                    if (int.TryParse(last.Substring(prefix.Length), out n)) next = n + 1;
                }
                return prefix + next.ToString(new string('0', digits));
            }
        }


        // Add a facility (ID like FA001)
        public int Facility_Add(string facilityId, string name, string university,
                                decimal ratePerHour, string type, string location)
        {
            using (var con = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(@"
        INSERT INTO Facility (FacilityID, Name, university, RatePerHour, type, Location)
        VALUES (@id,@n,@u,@r,@t,@l);", con))
            {
                cmd.Parameters.AddWithValue("@id", facilityId);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@u", university);
                cmd.Parameters.AddWithValue("@r", ratePerHour);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.Parameters.AddWithValue("@l", location);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Delete a facility by ID
        public int Facility_Delete(string facilityId)
        {
            using (var con = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand("DELETE FROM Facility WHERE FacilityID=@id;", con))
            {
                cmd.Parameters.AddWithValue("@id", facilityId);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Generate next FacilityID (FA001, FA002, ...)
        public string Facility_GenerateNextId()
        {
            using (var con = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(@"
        SELECT TOP(1) FacilityID
        FROM Facility
        WHERE FacilityID LIKE 'FA%'
        ORDER BY FacilityID DESC;", con))
            {
                con.Open();
                var last = cmd.ExecuteScalar() as string;   // e.g. "FA002"
                if (string.IsNullOrWhiteSpace(last) || last.Length < 3) return "FA001";

                if (!int.TryParse(last.Substring(2), out var num)) return "FA001";
                return "FA" + (num + 1).ToString("000");
            }
        }
        public DataTable Requests_List(string statusFilter = null, string requestIdLike = null)
        {
            const string Table = "MaintenanceRequests";

            using (var con = new SqlConnection(_connStr))
            using (var da = new SqlDataAdapter($@"
        SELECT RequestID, FacilityID, Staff, ProblemType, [Description], [Status]
        FROM {Table}
        WHERE (@status IS NULL OR @status = '' OR [Status] = @status)
          AND (@rid    IS NULL OR @rid    = '' OR CAST(RequestID AS NVARCHAR(50)) LIKE '%'+@rid+'%')
        ORDER BY RequestID;", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@status", (object)statusFilter ?? DBNull.Value);
                da.SelectCommand.Parameters.AddWithValue("@rid", (object)requestIdLike ?? DBNull.Value);

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int Requests_UpdateStatus(string requestId, string newStatus)
        {
            const string Table = "MaintenanceRequests";

            using (var con = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand($@"
        UPDATE {Table}
           SET [Status] = @status
         WHERE CAST(RequestID AS NVARCHAR(50)) = @rid;", con))
            {
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@rid", requestId);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetFacilities()
        {
            using (var con = new SqlConnection(_connStr))
            using (var da = new SqlDataAdapter(
                "SELECT FacilityID, Name FROM Facility ORDER BY FacilityID", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMaintenanceStaff()
        {
            using (var con = new SqlConnection(_connStr))
            using (var da = new SqlDataAdapter(
                "SELECT MaintenanceID, (FirstName + ' ' + LastName) AS FullName FROM MaintenanceStaff ORDER BY MaintenanceID", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetMaintenanceSchedules()
        {
            using (var conn = new SqlConnection(_connStr))
            {
                string sql = @"
            SELECT 
                ScheduleID,
                FacilityID,
                MaintenanceID,
                StartDate,
                EndDate,
                Task,
                CreatedBy
            FROM dbo.MaintenanceSchedule";

                using (var da = new SqlDataAdapter(sql, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public int AddSchedule(string facilityId, string maintenanceId, DateTime startDate, DateTime? endDate, string task, string createdByManagerId)
        {
            const string sql = @"
        INSERT INTO MaintenanceSchedule 
        (FacilityID, MaintenanceID, StartDate, EndDate, Task, CreatedBy)
        VALUES (@fid, @mid, @sd, @ed, @task, @mgr);";

            using (var conn = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@fid", facilityId);
                cmd.Parameters.AddWithValue("@mid", maintenanceId);
                cmd.Parameters.AddWithValue("@sd", startDate);
                cmd.Parameters.AddWithValue("@ed", (object)endDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@task", task);
                cmd.Parameters.AddWithValue("@mgr", createdByManagerId);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteSchedule(int scheduleId)
        {
            using (var con = new SqlConnection(_connStr))
            using (var cmd = new SqlCommand(
                "DELETE FROM dbo.MaintenanceSchedule WHERE ScheduleID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", scheduleId);
                con.Open();
                return cmd.ExecuteNonQuery();   // 1 when deleted
            }
        }

        public DataTable Facility_List(string q = null)
        {
            using (var con = new SqlConnection(_connStr))
            using (var da = new SqlDataAdapter(@"
        SELECT FacilityID, Name, university, RatePerHour, type, Location
        FROM Facility
        WHERE (@q IS NULL OR @q = '')
           OR FacilityID LIKE '%'+@q+'%'
           OR Name       LIKE '%'+@q+'%'
           OR university LIKE '%'+@q+'%'
           OR type       LIKE '%'+@q+'%'
           OR Location   LIKE '%'+@q+'%'
        ORDER BY FacilityID;", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@q", (object)q ?? DBNull.Value);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



    }
}

