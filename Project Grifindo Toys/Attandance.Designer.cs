namespace Project_Grifindo_Toys
{
    partial class Attandance
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
            this.attceTxt = new System.Windows.Forms.Label();
            this.attendanceGridView = new System.Windows.Forms.DataGridView();
            this.intimeLabel = new System.Windows.Forms.Label();
            this.txt_Attn_id = new System.Windows.Forms.TextBox();
            this.attndText = new System.Windows.Forms.Label();
            this.txt_inTime = new System.Windows.Forms.DateTimePicker();
            this.txt_outTime = new System.Windows.Forms.DateTimePicker();
            this.outtimeTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_EmpFk = new System.Windows.Forms.ComboBox();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.attceTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 24;
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
            this.btnclose.Location = new System.Drawing.Point(997, 7);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // attceTxt
            // 
            this.attceTxt.AutoSize = true;
            this.attceTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attceTxt.ForeColor = System.Drawing.Color.White;
            this.attceTxt.Location = new System.Drawing.Point(748, 4);
            this.attceTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attceTxt.Name = "attceTxt";
            this.attceTxt.Size = new System.Drawing.Size(242, 46);
            this.attceTxt.TabIndex = 1;
            this.attceTxt.Text = "ATTENDANCE";
            // 
            // attendanceGridView
            // 
            this.attendanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGridView.Location = new System.Drawing.Point(17, 536);
            this.attendanceGridView.Margin = new System.Windows.Forms.Padding(4);
            this.attendanceGridView.Name = "attendanceGridView";
            this.attendanceGridView.RowHeadersWidth = 51;
            this.attendanceGridView.Size = new System.Drawing.Size(1005, 238);
            this.attendanceGridView.TabIndex = 50;
            this.attendanceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceGridView_CellContentClick);
            // 
            // intimeLabel
            // 
            this.intimeLabel.AutoSize = true;
            this.intimeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intimeLabel.ForeColor = System.Drawing.Color.White;
            this.intimeLabel.Location = new System.Drawing.Point(103, 151);
            this.intimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intimeLabel.Name = "intimeLabel";
            this.intimeLabel.Size = new System.Drawing.Size(114, 32);
            this.intimeLabel.TabIndex = 53;
            this.intimeLabel.Text = "In Time :";
            // 
            // txt_Attn_id
            // 
            this.txt_Attn_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Attn_id.Location = new System.Drawing.Point(225, 96);
            this.txt_Attn_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Attn_id.Name = "txt_Attn_id";
            this.txt_Attn_id.Size = new System.Drawing.Size(265, 32);
            this.txt_Attn_id.TabIndex = 52;
            // 
            // attndText
            // 
            this.attndText.AutoSize = true;
            this.attndText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attndText.ForeColor = System.Drawing.Color.White;
            this.attndText.Location = new System.Drawing.Point(25, 96);
            this.attndText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attndText.Name = "attndText";
            this.attndText.Size = new System.Drawing.Size(192, 32);
            this.attndText.TabIndex = 51;
            this.attndText.Text = "Attendance ID :";
            // 
            // txt_inTime
            // 
            this.txt_inTime.CustomFormat = "MM/dd/yyy HH:mm:ss";
            this.txt_inTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_inTime.Location = new System.Drawing.Point(225, 151);
            this.txt_inTime.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inTime.Name = "txt_inTime";
            this.txt_inTime.Size = new System.Drawing.Size(265, 34);
            this.txt_inTime.TabIndex = 55;
            this.txt_inTime.Value = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // txt_outTime
            // 
            this.txt_outTime.CustomFormat = "MM/dd/yyy HH:mm:ss";
            this.txt_outTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_outTime.Location = new System.Drawing.Point(225, 212);
            this.txt_outTime.Margin = new System.Windows.Forms.Padding(4);
            this.txt_outTime.Name = "txt_outTime";
            this.txt_outTime.Size = new System.Drawing.Size(265, 34);
            this.txt_outTime.TabIndex = 57;
            this.txt_outTime.Value = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // outtimeTxt
            // 
            this.outtimeTxt.AutoSize = true;
            this.outtimeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outtimeTxt.ForeColor = System.Drawing.Color.White;
            this.outtimeTxt.Location = new System.Drawing.Point(84, 212);
            this.outtimeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outtimeTxt.Name = "outtimeTxt";
            this.outtimeTxt.Size = new System.Drawing.Size(133, 32);
            this.outtimeTxt.TabIndex = 56;
            this.outtimeTxt.Text = "Out Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Employee :";
            // 
            // combo_EmpFk
            // 
            this.combo_EmpFk.FormattingEnabled = true;
            this.combo_EmpFk.Location = new System.Drawing.Point(225, 276);
            this.combo_EmpFk.Name = "combo_EmpFk";
            this.combo_EmpFk.Size = new System.Drawing.Size(265, 24);
            this.combo_EmpFk.TabIndex = 59;
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
            this.btuDelete.Location = new System.Drawing.Point(831, 472);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 63;
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
            this.btuUpdate.Location = new System.Drawing.Point(626, 472);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 62;
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
            this.btuClear.Location = new System.Drawing.Point(626, 406);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 61;
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
            this.btuSave.Location = new System.Drawing.Point(831, 406);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 60;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // Attandance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.combo_EmpFk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_outTime);
            this.Controls.Add(this.outtimeTxt);
            this.Controls.Add(this.txt_inTime);
            this.Controls.Add(this.intimeLabel);
            this.Controls.Add(this.txt_Attn_id);
            this.Controls.Add(this.attndText);
            this.Controls.Add(this.attendanceGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attandance";
            this.Text = "Attandance";
            this.Load += new System.EventHandler(this.Attandance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label attceTxt;
        private System.Windows.Forms.DataGridView attendanceGridView;
        private System.Windows.Forms.Label intimeLabel;
        private System.Windows.Forms.TextBox txt_Attn_id;
        private System.Windows.Forms.Label attndText;
        private System.Windows.Forms.DateTimePicker txt_inTime;
        private System.Windows.Forms.DateTimePicker txt_outTime;
        private System.Windows.Forms.Label outtimeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_EmpFk;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.Button btnclose;
    }
}