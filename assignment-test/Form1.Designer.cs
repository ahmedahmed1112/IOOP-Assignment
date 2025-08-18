namespace assignment_test
{
    partial class Form1
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
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRole.Location = new System.Drawing.Point(349, 9);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(75, 24);
            this.lblSelectRole.TabIndex = 8;
            this.lblSelectRole.Text = "Log In";
            this.lblSelectRole.Click += new System.EventHandler(this.lblSelectRole_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(616, 255);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(78, 30);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(384, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 22);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(384, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(77, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(296, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(231, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(127, 16);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username Or Email:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 313);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblSelectRole);
            this.Name = "Form1";
            this.Text = "Log In Page";
            this.Load += new System.EventHandler(this.FormRoleSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}
