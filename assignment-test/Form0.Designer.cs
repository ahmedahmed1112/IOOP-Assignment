namespace assignment_test
{
    partial class Form0
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
            this.btnManager = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnMaintenanceStaff = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.Location = new System.Drawing.Point(131, 74);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(212, 43);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(131, 366);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(212, 44);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReception
            // 
            this.btnReception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReception.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnReception.ForeColor = System.Drawing.Color.Black;
            this.btnReception.Location = new System.Drawing.Point(131, 140);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(212, 43);
            this.btnReception.TabIndex = 5;
            this.btnReception.Text = "Reception";
            this.btnReception.UseVisualStyleBackColor = false;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.Black;
            this.btnStudent.Location = new System.Drawing.Point(131, 206);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(212, 43);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnMaintenanceStaff
            // 
            this.btnMaintenanceStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMaintenanceStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaintenanceStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceStaff.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMaintenanceStaff.ForeColor = System.Drawing.Color.Black;
            this.btnMaintenanceStaff.Location = new System.Drawing.Point(131, 267);
            this.btnMaintenanceStaff.Name = "btnMaintenanceStaff";
            this.btnMaintenanceStaff.Size = new System.Drawing.Size(212, 43);
            this.btnMaintenanceStaff.TabIndex = 7;
            this.btnMaintenanceStaff.Text = "Maintenance Staff ";
            this.btnMaintenanceStaff.UseVisualStyleBackColor = false;
            this.btnMaintenanceStaff.Click += new System.EventHandler(this.btnMaintenanceStaff_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(515, 485);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnMaintenanceStaff);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnReception);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnManager);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form0";
            this.Text = "Form0";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnMaintenanceStaff;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}