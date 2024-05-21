namespace Project_Grifindo_Toys
{
    partial class leave
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.leaveTxt = new System.Windows.Forms.Label();
            this.txt_LeaveID = new System.Windows.Forms.TextBox();
            this.leavelabel = new System.Windows.Forms.Label();
            this.txt_casualL = new System.Windows.Forms.TextBox();
            this.casualLeaveLabel = new System.Windows.Forms.Label();
            this.txt_annualL = new System.Windows.Forms.TextBox();
            this.annualLeaveLabel = new System.Windows.Forms.Label();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.leaveGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.leaveTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 27;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(990, 6);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 83;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // leaveTxt
            // 
            this.leaveTxt.AutoSize = true;
            this.leaveTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTxt.ForeColor = System.Drawing.Color.White;
            this.leaveTxt.Location = new System.Drawing.Point(864, 6);
            this.leaveTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leaveTxt.Name = "leaveTxt";
            this.leaveTxt.Size = new System.Drawing.Size(118, 46);
            this.leaveTxt.TabIndex = 1;
            this.leaveTxt.Text = "LEAVE";
            // 
            // txt_LeaveID
            // 
            this.txt_LeaveID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LeaveID.Location = new System.Drawing.Point(242, 120);
            this.txt_LeaveID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LeaveID.Name = "txt_LeaveID";
            this.txt_LeaveID.Size = new System.Drawing.Size(276, 32);
            this.txt_LeaveID.TabIndex = 58;
            // 
            // leavelabel
            // 
            this.leavelabel.AutoSize = true;
            this.leavelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leavelabel.ForeColor = System.Drawing.Color.White;
            this.leavelabel.Location = new System.Drawing.Point(109, 120);
            this.leavelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leavelabel.Name = "leavelabel";
            this.leavelabel.Size = new System.Drawing.Size(125, 32);
            this.leavelabel.TabIndex = 57;
            this.leavelabel.Text = "Leave ID :";
            // 
            // txt_casualL
            // 
            this.txt_casualL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_casualL.Location = new System.Drawing.Point(242, 241);
            this.txt_casualL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_casualL.Name = "txt_casualL";
            this.txt_casualL.Size = new System.Drawing.Size(276, 32);
            this.txt_casualL.TabIndex = 64;
            // 
            // casualLeaveLabel
            // 
            this.casualLeaveLabel.AutoSize = true;
            this.casualLeaveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casualLeaveLabel.ForeColor = System.Drawing.Color.White;
            this.casualLeaveLabel.Location = new System.Drawing.Point(61, 238);
            this.casualLeaveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casualLeaveLabel.Name = "casualLeaveLabel";
            this.casualLeaveLabel.Size = new System.Drawing.Size(173, 32);
            this.casualLeaveLabel.TabIndex = 63;
            this.casualLeaveLabel.Text = "Casual Leave :";
            // 
            // txt_annualL
            // 
            this.txt_annualL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_annualL.Location = new System.Drawing.Point(242, 182);
            this.txt_annualL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_annualL.Name = "txt_annualL";
            this.txt_annualL.Size = new System.Drawing.Size(276, 32);
            this.txt_annualL.TabIndex = 62;
            // 
            // annualLeaveLabel
            // 
            this.annualLeaveLabel.AutoSize = true;
            this.annualLeaveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualLeaveLabel.ForeColor = System.Drawing.Color.White;
            this.annualLeaveLabel.Location = new System.Drawing.Point(53, 180);
            this.annualLeaveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.annualLeaveLabel.Name = "annualLeaveLabel";
            this.annualLeaveLabel.Size = new System.Drawing.Size(181, 32);
            this.annualLeaveLabel.TabIndex = 61;
            this.annualLeaveLabel.Text = "Annual Leave :";
            // 
            // btuDelete
            // 
            this.btuDelete.BackColor = System.Drawing.Color.DimGray;
            this.btuDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btuDelete.FlatAppearance.BorderSize = 0;
            this.btuDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuDelete.ForeColor = System.Drawing.Color.White;
            this.btuDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuDelete.Location = new System.Drawing.Point(828, 475);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 81;
            this.btuDelete.Text = "DELETE";
            this.btuDelete.UseVisualStyleBackColor = false;
            this.btuDelete.Click += new System.EventHandler(this.btuDelete_Click);
            // 
            // btuUpdate
            // 
            this.btuUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btuUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btuUpdate.FlatAppearance.BorderSize = 0;
            this.btuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuUpdate.ForeColor = System.Drawing.Color.White;
            this.btuUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuUpdate.Location = new System.Drawing.Point(623, 475);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 80;
            this.btuUpdate.Text = "UPDATE";
            this.btuUpdate.UseVisualStyleBackColor = false;
            this.btuUpdate.Click += new System.EventHandler(this.btuUpdate_Click);
            // 
            // btuClear
            // 
            this.btuClear.BackColor = System.Drawing.Color.DimGray;
            this.btuClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btuClear.FlatAppearance.BorderSize = 0;
            this.btuClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuClear.ForeColor = System.Drawing.Color.White;
            this.btuClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuClear.Location = new System.Drawing.Point(623, 409);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 79;
            this.btuClear.Text = "CLEAR";
            this.btuClear.UseVisualStyleBackColor = false;
            this.btuClear.Click += new System.EventHandler(this.btuClear_Click);
            // 
            // btuSave
            // 
            this.btuSave.BackColor = System.Drawing.Color.DimGray;
            this.btuSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btuSave.FlatAppearance.BorderSize = 0;
            this.btuSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btuSave.ForeColor = System.Drawing.Color.White;
            this.btuSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btuSave.Location = new System.Drawing.Point(828, 409);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 78;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // leaveGridView
            // 
            this.leaveGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveGridView.Location = new System.Drawing.Point(21, 536);
            this.leaveGridView.Margin = new System.Windows.Forms.Padding(4);
            this.leaveGridView.Name = "leaveGridView";
            this.leaveGridView.RowHeadersWidth = 51;
            this.leaveGridView.Size = new System.Drawing.Size(1009, 238);
            this.leaveGridView.TabIndex = 82;
            this.leaveGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveGridView_CellContentClick);
            // 
            // leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.leaveGridView);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.txt_casualL);
            this.Controls.Add(this.casualLeaveLabel);
            this.Controls.Add(this.txt_annualL);
            this.Controls.Add(this.annualLeaveLabel);
            this.Controls.Add(this.txt_LeaveID);
            this.Controls.Add(this.leavelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "leave";
            this.Text = "leave";
            this.Load += new System.EventHandler(this.leave_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label leaveTxt;
        private System.Windows.Forms.TextBox txt_LeaveID;
        private System.Windows.Forms.Label leavelabel;
        private System.Windows.Forms.TextBox txt_casualL;
        private System.Windows.Forms.Label casualLeaveLabel;
        private System.Windows.Forms.TextBox txt_annualL;
        private System.Windows.Forms.Label annualLeaveLabel;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.DataGridView leaveGridView;
        private System.Windows.Forms.Button btnclose;
    }
}