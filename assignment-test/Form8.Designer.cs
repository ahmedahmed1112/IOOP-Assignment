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
            this.DGV_ReviewRequests = new System.Windows.Forms.DataGridView();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblSearchRequestID = new System.Windows.Forms.Label();
            this.txtSearchReqID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReviewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRequestID
            // 
            this.btnSearchRequestID.BackColor = System.Drawing.Color.Aqua;
            this.btnSearchRequestID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchRequestID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRequestID.Location = new System.Drawing.Point(10, 139);
            this.btnSearchRequestID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchRequestID.Name = "btnSearchRequestID";
            this.btnSearchRequestID.Size = new System.Drawing.Size(69, 29);
            this.btnSearchRequestID.TabIndex = 0;
            this.btnSearchRequestID.Text = "Search";
            this.btnSearchRequestID.UseVisualStyleBackColor = false;
            this.btnSearchRequestID.Click += new System.EventHandler(this.btnSearchRequestID_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // DGV_ReviewRequests
            // 
            this.DGV_ReviewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ReviewRequests.Location = new System.Drawing.Point(213, 0);
            this.DGV_ReviewRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_ReviewRequests.Name = "DGV_ReviewRequests";
            this.DGV_ReviewRequests.RowHeadersVisible = false;
            this.DGV_ReviewRequests.RowHeadersWidth = 51;
            this.DGV_ReviewRequests.RowTemplate.Height = 26;
            this.DGV_ReviewRequests.Size = new System.Drawing.Size(645, 340);
            this.DGV_ReviewRequests.TabIndex = 3;
            this.DGV_ReviewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ReviewRequests_CellContentClick);
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Items.AddRange(new object[] {
            "",
            "Pending",
            "Approved",
            "Rejected"});
            this.lstStatus.Location = new System.Drawing.Point(10, 24);
            this.lstStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(103, 17);
            this.lstStatus.TabIndex = 24;
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
            this.btnGoBack.Location = new System.Drawing.Point(10, 304);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(90, 28);
            this.btnGoBack.TabIndex = 34;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSearchRequestID
            // 
            this.lblSearchRequestID.AutoSize = true;
            this.lblSearchRequestID.Location = new System.Drawing.Point(8, 98);
            this.lblSearchRequestID.Name = "lblSearchRequestID";
            this.lblSearchRequestID.Size = new System.Drawing.Size(98, 13);
            this.lblSearchRequestID.TabIndex = 35;
            this.lblSearchRequestID.Text = "Search RequestID:";
            // 
            // txtSearchReqID
            // 
            this.txtSearchReqID.Location = new System.Drawing.Point(10, 115);
            this.txtSearchReqID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchReqID.Name = "txtSearchReqID";
            this.txtSearchReqID.Size = new System.Drawing.Size(103, 20);
            this.txtSearchReqID.TabIndex = 36;
            this.txtSearchReqID.TextChanged += new System.EventHandler(this.txtSearchReqID_TextChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(858, 342);
            this.Controls.Add(this.txtSearchReqID);
            this.Controls.Add(this.lblSearchRequestID);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.DGV_ReviewRequests);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearchRequestID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form8";
            this.Text = "Review Maintenance Requests";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReviewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRequestID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView DGV_ReviewRequests;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblSearchRequestID;
        private System.Windows.Forms.TextBox txtSearchReqID;
    }
}