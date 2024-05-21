namespace Project_Grifindo_Toys
{
    partial class applied_Leaves
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
            this.appleaveTxt = new System.Windows.Forms.Label();
            this.txt_appliedID = new System.Windows.Forms.TextBox();
            this.appliedleavelabel = new System.Windows.Forms.Label();
            this.combo_EmpFk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Leavestart = new System.Windows.Forms.DateTimePicker();
            this.txt_leaveend = new System.Windows.Forms.DateTimePicker();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.appliedDataGridView = new System.Windows.Forms.DataGridView();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.appleaveTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 28;
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
            this.btnclose.Location = new System.Drawing.Point(1000, 5);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // appleaveTxt
            // 
            this.appleaveTxt.AutoSize = true;
            this.appleaveTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appleaveTxt.ForeColor = System.Drawing.Color.White;
            this.appleaveTxt.Location = new System.Drawing.Point(707, 5);
            this.appleaveTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appleaveTxt.Name = "appleaveTxt";
            this.appleaveTxt.Size = new System.Drawing.Size(283, 46);
            this.appleaveTxt.TabIndex = 1;
            this.appleaveTxt.Text = "APPLIED LEAVES";
            // 
            // txt_appliedID
            // 
            this.txt_appliedID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appliedID.Location = new System.Drawing.Point(257, 120);
            this.txt_appliedID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_appliedID.Name = "txt_appliedID";
            this.txt_appliedID.Size = new System.Drawing.Size(276, 32);
            this.txt_appliedID.TabIndex = 60;
            // 
            // appliedleavelabel
            // 
            this.appliedleavelabel.AutoSize = true;
            this.appliedleavelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedleavelabel.ForeColor = System.Drawing.Color.White;
            this.appliedleavelabel.Location = new System.Drawing.Point(99, 120);
            this.appliedleavelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appliedleavelabel.Name = "appliedleavelabel";
            this.appliedleavelabel.Size = new System.Drawing.Size(150, 32);
            this.appliedleavelabel.TabIndex = 59;
            this.appliedleavelabel.Text = "Applied ID :";
            // 
            // combo_EmpFk
            // 
            this.combo_EmpFk.FormattingEnabled = true;
            this.combo_EmpFk.Location = new System.Drawing.Point(256, 182);
            this.combo_EmpFk.Name = "combo_EmpFk";
            this.combo_EmpFk.Size = new System.Drawing.Size(277, 24);
            this.combo_EmpFk.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Employee :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "Leave End Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 70;
            this.label3.Text = "Leave Start Date :";
            // 
            // txt_Leavestart
            // 
            this.txt_Leavestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Leavestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Leavestart.Location = new System.Drawing.Point(257, 226);
            this.txt_Leavestart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Leavestart.Name = "txt_Leavestart";
            this.txt_Leavestart.Size = new System.Drawing.Size(334, 34);
            this.txt_Leavestart.TabIndex = 72;
            this.txt_Leavestart.Value = new System.DateTime(2023, 8, 21, 0, 0, 0, 0);
            // 
            // txt_leaveend
            // 
            this.txt_leaveend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leaveend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_leaveend.Location = new System.Drawing.Point(257, 282);
            this.txt_leaveend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leaveend.Name = "txt_leaveend";
            this.txt_leaveend.Size = new System.Drawing.Size(334, 34);
            this.txt_leaveend.TabIndex = 71;
            this.txt_leaveend.Value = new System.DateTime(2023, 8, 25, 0, 0, 0, 0);
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(696, 154);
            this.txt_reason.Margin = new System.Windows.Forms.Padding(4);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(324, 52);
            this.txt_reason.TabIndex = 74;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.ForeColor = System.Drawing.Color.White;
            this.reasonLabel.Location = new System.Drawing.Point(612, 117);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(212, 32);
            this.reasonLabel.TabIndex = 73;
            this.reasonLabel.Text = "Reason of Leave :";
            // 
            // appliedDataGridView
            // 
            this.appliedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appliedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliedDataGridView.Location = new System.Drawing.Point(19, 536);
            this.appliedDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appliedDataGridView.Name = "appliedDataGridView";
            this.appliedDataGridView.RowHeadersWidth = 51;
            this.appliedDataGridView.Size = new System.Drawing.Size(1014, 238);
            this.appliedDataGridView.TabIndex = 83;
            this.appliedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appliedDataGridView_CellContentClick);
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
            this.btuDelete.Location = new System.Drawing.Point(828, 470);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 87;
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
            this.btuUpdate.Location = new System.Drawing.Point(623, 470);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 86;
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
            this.btuClear.Location = new System.Drawing.Point(623, 404);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 85;
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
            this.btuSave.Location = new System.Drawing.Point(828, 404);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 84;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // applied_Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.appliedDataGridView);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.txt_Leavestart);
            this.Controls.Add(this.txt_leaveend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_EmpFk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_appliedID);
            this.Controls.Add(this.appliedleavelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "applied_Leaves";
            this.Text = "applied_Leaves";
            this.Load += new System.EventHandler(this.applied_Leaves_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appleaveTxt;
        private System.Windows.Forms.TextBox txt_appliedID;
        private System.Windows.Forms.Label appliedleavelabel;
        private System.Windows.Forms.ComboBox combo_EmpFk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_Leavestart;
        private System.Windows.Forms.DateTimePicker txt_leaveend;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.DataGridView appliedDataGridView;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.Button btnclose;
    }
}