namespace assignment_test
{
    partial class formAssignMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTask = new System.Windows.Forms.Label();
            this.lstFacility = new System.Windows.Forms.ListBox();
            this.lstMaintenanceStaff = new System.Windows.Forms.ListBox();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblMaintenanceStaff = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnScehduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAssignedFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAssignedStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(76, 242);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(29, 13);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task";
            // 
            // lstFacility
            // 
            this.lstFacility.FormattingEnabled = true;
            this.lstFacility.Items.AddRange(new object[] {
            ""});
            this.lstFacility.Location = new System.Drawing.Point(123, 96);
            this.lstFacility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFacility.Name = "lstFacility";
            this.lstFacility.Size = new System.Drawing.Size(103, 17);
            this.lstFacility.TabIndex = 23;
            this.lstFacility.SelectedIndexChanged += new System.EventHandler(this.lstFacility_SelectedIndexChanged);
            // 
            // lstMaintenanceStaff
            // 
            this.lstMaintenanceStaff.FormattingEnabled = true;
            this.lstMaintenanceStaff.Items.AddRange(new object[] {
            ""});
            this.lstMaintenanceStaff.Location = new System.Drawing.Point(123, 130);
            this.lstMaintenanceStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMaintenanceStaff.Name = "lstMaintenanceStaff";
            this.lstMaintenanceStaff.Size = new System.Drawing.Size(103, 17);
            this.lstMaintenanceStaff.TabIndex = 24;
            this.lstMaintenanceStaff.SelectedIndexChanged += new System.EventHandler(this.lstMaintenanceStaff_SelectedIndexChanged);
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Location = new System.Drawing.Point(66, 96);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(40, 13);
            this.lblFacility.TabIndex = 25;
            this.lblFacility.Text = "Facility";
            this.lblFacility.Click += new System.EventHandler(this.lblFacility_Click);
            // 
            // lblMaintenanceStaff
            // 
            this.lblMaintenanceStaff.AutoSize = true;
            this.lblMaintenanceStaff.Location = new System.Drawing.Point(8, 130);
            this.lblMaintenanceStaff.Name = "lblMaintenanceStaff";
            this.lblMaintenanceStaff.Size = new System.Drawing.Size(95, 13);
            this.lblMaintenanceStaff.TabIndex = 26;
            this.lblMaintenanceStaff.Text = "Maintenance Staff";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(46, 159);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(57, 13);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start Date";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(123, 240);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(103, 20);
            this.txtTask.TabIndex = 29;
            this.txtTask.TextChanged += new System.EventHandler(this.txtTask_TextChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(51, 200);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(51, 13);
            this.lblEndDate.TabIndex = 31;
            this.lblEndDate.Text = "End Date";
            // 
            // btnGoBack
            // 
            this.btnGoBack.AutoSize = true;
            this.btnGoBack.BackColor = System.Drawing.Color.Tomato;
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(10, 10);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(90, 28);
            this.btnGoBack.TabIndex = 33;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnScehduleID,
            this.clnAssignedFacility,
            this.clnStartDate,
            this.clnAssignedStaff,
            this.clnEndDate,
            this.clnTask,
            this.clnCreatedBy});
            this.dataGridView1.Location = new System.Drawing.Point(328, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(537, 320);
            this.dataGridView1.TabIndex = 34;
            // 
            // clnScehduleID
            // 
            this.clnScehduleID.HeaderText = "ScehduleID";
            this.clnScehduleID.Name = "clnScehduleID";
            this.clnScehduleID.ReadOnly = true;
            // 
            // clnAssignedFacility
            // 
            this.clnAssignedFacility.HeaderText = "AssignedFacility";
            this.clnAssignedFacility.Name = "clnAssignedFacility";
            this.clnAssignedFacility.ReadOnly = true;
            // 
            // clnStartDate
            // 
            this.clnStartDate.HeaderText = "StartDate";
            this.clnStartDate.Name = "clnStartDate";
            this.clnStartDate.ReadOnly = true;
            // 
            // clnAssignedStaff
            // 
            this.clnAssignedStaff.HeaderText = "AssignedStaff";
            this.clnAssignedStaff.Name = "clnAssignedStaff";
            this.clnAssignedStaff.ReadOnly = true;
            // 
            // clnEndDate
            // 
            this.clnEndDate.HeaderText = "EndDate";
            this.clnEndDate.Name = "clnEndDate";
            this.clnEndDate.ReadOnly = true;
            // 
            // clnTask
            // 
            this.clnTask.HeaderText = "Task";
            this.clnTask.Name = "clnTask";
            this.clnTask.ReadOnly = true;
            // 
            // clnCreatedBy
            // 
            this.clnCreatedBy.HeaderText = "CreatedBy";
            this.clnCreatedBy.Name = "clnCreatedBy";
            this.clnCreatedBy.ReadOnly = true;
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Location = new System.Drawing.Point(123, 159);
            this.DTPStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(193, 20);
            this.DTPStartDate.TabIndex = 35;
            this.DTPStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(123, 284);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(88, 23);
            this.btnAddSchedule.TabIndex = 36;
            this.btnAddSchedule.Text = "AddSchedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(123, 198);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Location = new System.Drawing.Point(254, 200);
            this.DTPEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(193, 20);
            this.DTPEndDate.TabIndex = 37;
            // 
            // formAssignMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(864, 319);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMaintenanceStaff);
            this.Controls.Add(this.lblFacility);
            this.Controls.Add(this.lstMaintenanceStaff);
            this.Controls.Add(this.lstFacility);
            this.Controls.Add(this.lblTask);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAssignMaintenance";
            this.Text = "Assign Maintenance";
            this.Load += new System.EventHandler(this.formAssignMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ListBox lstFacility;
        private System.Windows.Forms.ListBox lstMaintenanceStaff;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblMaintenanceStaff;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnScehduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssignedFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAssignedStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCreatedBy;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
    }
}