namespace assignment_test
{
    partial class Form8
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
            this.btnSearchRequestID = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSearchRequestID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clnRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProblemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRequestID
            // 
            this.btnSearchRequestID.BackColor = System.Drawing.Color.Aqua;
            this.btnSearchRequestID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchRequestID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRequestID.Location = new System.Drawing.Point(12, 171);
            this.btnSearchRequestID.Name = "btnSearchRequestID";
            this.btnSearchRequestID.Size = new System.Drawing.Size(80, 36);
            this.btnSearchRequestID.TabIndex = 0;
            this.btnSearchRequestID.Text = "Search";
            this.btnSearchRequestID.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnRequestID,
            this.clnFacilityID,
            this.clnStaff,
            this.clnProblemType,
            this.clnDescription,
            this.clnStatus});
            this.dataGridView1.Location = new System.Drawing.Point(248, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(753, 612);
            this.dataGridView1.TabIndex = 3;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 16;
            this.lstStatus.Items.AddRange(new object[] {
            "",
            "Pending",
            "Approved",
            "Rejected"});
            this.lstStatus.Location = new System.Drawing.Point(12, 29);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(120, 20);
            this.lstStatus.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 34;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblSearchRequestID
            // 
            this.lblSearchRequestID.AutoSize = true;
            this.lblSearchRequestID.Location = new System.Drawing.Point(9, 121);
            this.lblSearchRequestID.Name = "lblSearchRequestID";
            this.lblSearchRequestID.Size = new System.Drawing.Size(123, 17);
            this.lblSearchRequestID.TabIndex = 35;
            this.lblSearchRequestID.Text = "Search RequestID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 24);
            this.textBox1.TabIndex = 36;
            // 
            // clnRequestID
            // 
            this.clnRequestID.HeaderText = "Request ID";
            this.clnRequestID.MinimumWidth = 6;
            this.clnRequestID.Name = "clnRequestID";
            this.clnRequestID.Width = 125;
            // 
            // clnFacilityID
            // 
            this.clnFacilityID.HeaderText = "Facility ID";
            this.clnFacilityID.MinimumWidth = 6;
            this.clnFacilityID.Name = "clnFacilityID";
            this.clnFacilityID.Width = 125;
            // 
            // clnStaff
            // 
            this.clnStaff.HeaderText = "Staff";
            this.clnStaff.MinimumWidth = 6;
            this.clnStaff.Name = "clnStaff";
            this.clnStaff.Width = 125;
            // 
            // clnProblemType
            // 
            this.clnProblemType.HeaderText = "Problem Type";
            this.clnProblemType.MinimumWidth = 6;
            this.clnProblemType.Name = "clnProblemType";
            this.clnProblemType.Width = 125;
            // 
            // clnDescription
            // 
            this.clnDescription.HeaderText = "Description";
            this.clnDescription.MinimumWidth = 6;
            this.clnDescription.Name = "clnDescription";
            this.clnDescription.Width = 125;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.MinimumWidth = 6;
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.Width = 125;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1001, 613);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSearchRequestID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearchRequestID);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRequestID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSearchRequestID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProblemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}