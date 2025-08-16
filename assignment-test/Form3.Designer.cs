namespace assignment_test
{
    partial class formManageUsers
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnGoBack.Location = new System.Drawing.Point(29, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(105, 35);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnFullName,
            this.clnUsername,
            this.clnEmail,
            this.clnRole,
            this.clnPhone});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(689, 222);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 17);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 24);
            this.txtSearch.TabIndex = 16;
            // 
            // clnID
            // 
            this.clnID.HeaderText = "ID";
            this.clnID.MinimumWidth = 2;
            this.clnID.Name = "clnID";
            this.clnID.Width = 60;
            // 
            // clnFullName
            // 
            this.clnFullName.HeaderText = "Full Name";
            this.clnFullName.MinimumWidth = 6;
            this.clnFullName.Name = "clnFullName";
            this.clnFullName.Width = 125;
            // 
            // clnUsername
            // 
            this.clnUsername.HeaderText = "Username";
            this.clnUsername.MinimumWidth = 6;
            this.clnUsername.Name = "clnUsername";
            this.clnUsername.Width = 125;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 6;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.Width = 125;
            // 
            // clnRole
            // 
            this.clnRole.HeaderText = "Role";
            this.clnRole.MinimumWidth = 6;
            this.clnRole.Name = "clnRole";
            this.clnRole.Width = 125;
            // 
            // clnPhone
            // 
            this.clnPhone.HeaderText = "Phone";
            this.clnPhone.MinimumWidth = 6;
            this.clnPhone.Name = "clnPhone";
            this.clnPhone.Width = 125;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Aqua;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(562, 148);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(99, 36);
            this.btnAddUser.TabIndex = 17;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSize = true;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Location = new System.Drawing.Point(29, 148);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(99, 36);
            this.btnDeleteUser.TabIndex = 18;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSize = true;
            this.btnEditUser.BackColor = System.Drawing.Color.Aqua;
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.Black;
            this.btnEditUser.Location = new System.Drawing.Point(286, 148);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(99, 36);
            this.btnEditUser.TabIndex = 19;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Location = new System.Drawing.Point(461, 25);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(71, 17);
            this.lblFilterRole.TabIndex = 21;
            this.lblFilterRole.Text = "Filter Role:";
            // 
            // lstRoles
            // 
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.ItemHeight = 16;
            this.lstRoles.Items.AddRange(new object[] {
            "Reception",
            "Maintenance Staff"});
            this.lstRoles.Location = new System.Drawing.Point(556, 25);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(120, 20);
            this.lstRoles.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lstRoles);
            this.panel1.Controls.Add(this.lblFilterRole);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(-1, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 65);
            this.panel1.TabIndex = 23;
            // 
            // formManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(687, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGoBack);
            this.Name = "formManageUsers";
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhone;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label lblFilterRole;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.Panel panel1;
    }
}