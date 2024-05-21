namespace Project_Grifindo_Toys
{
    partial class setting
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.settingTxt = new System.Windows.Forms.Label();
            this.txt_settingID = new System.Windows.Forms.TextBox();
            this.settingIdlabel = new System.Windows.Forms.Label();
            this.combo_AdminFk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numberOfPerYear = new System.Windows.Forms.TextBox();
            this.Salary_Begin_dateLabel = new System.Windows.Forms.Label();
            this.txt_salaryCycleDurations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingGridView = new System.Windows.Forms.DataGridView();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.datetxt_salaryBeginDate = new System.Windows.Forms.DateTimePicker();
            this.datetxt_salaryEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.settingTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 58);
            this.panel2.TabIndex = 96;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(995, 7);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(44, 44);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(832, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "SETTING";
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
            this.btnclose.Location = new System.Drawing.Point(995, 7);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // settingTxt
            // 
            this.settingTxt.AutoSize = true;
            this.settingTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingTxt.ForeColor = System.Drawing.Color.White;
            this.settingTxt.Location = new System.Drawing.Point(832, 5);
            this.settingTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settingTxt.Name = "settingTxt";
            this.settingTxt.Size = new System.Drawing.Size(160, 46);
            this.settingTxt.TabIndex = 1;
            this.settingTxt.Text = "SETTING";
            // 
            // txt_settingID
            // 
            this.txt_settingID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_settingID.Location = new System.Drawing.Point(241, 126);
            this.txt_settingID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_settingID.Name = "txt_settingID";
            this.txt_settingID.Size = new System.Drawing.Size(243, 32);
            this.txt_settingID.TabIndex = 64;
            // 
            // settingIdlabel
            // 
            this.settingIdlabel.AutoSize = true;
            this.settingIdlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingIdlabel.ForeColor = System.Drawing.Color.White;
            this.settingIdlabel.Location = new System.Drawing.Point(89, 126);
            this.settingIdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settingIdlabel.Name = "settingIdlabel";
            this.settingIdlabel.Size = new System.Drawing.Size(142, 32);
            this.settingIdlabel.TabIndex = 63;
            this.settingIdlabel.Text = "Setting ID :";
            // 
            // combo_AdminFk
            // 
            this.combo_AdminFk.FormattingEnabled = true;
            this.combo_AdminFk.Location = new System.Drawing.Point(241, 185);
            this.combo_AdminFk.Name = "combo_AdminFk";
            this.combo_AdminFk.Size = new System.Drawing.Size(243, 24);
            this.combo_AdminFk.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Admin :";
            // 
            // txt_numberOfPerYear
            // 
            this.txt_numberOfPerYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberOfPerYear.Location = new System.Drawing.Point(299, 344);
            this.txt_numberOfPerYear.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numberOfPerYear.Name = "txt_numberOfPerYear";
            this.txt_numberOfPerYear.Size = new System.Drawing.Size(282, 32);
            this.txt_numberOfPerYear.TabIndex = 74;
            // 
            // Salary_Begin_dateLabel
            // 
            this.Salary_Begin_dateLabel.AutoSize = true;
            this.Salary_Begin_dateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_Begin_dateLabel.ForeColor = System.Drawing.Color.White;
            this.Salary_Begin_dateLabel.Location = new System.Drawing.Point(9, 229);
            this.Salary_Begin_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salary_Begin_dateLabel.Name = "Salary_Begin_dateLabel";
            this.Salary_Begin_dateLabel.Size = new System.Drawing.Size(230, 32);
            this.Salary_Begin_dateLabel.TabIndex = 73;
            this.Salary_Begin_dateLabel.Text = "Salary Begin Date :";
            // 
            // txt_salaryCycleDurations
            // 
            this.txt_salaryCycleDurations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaryCycleDurations.Location = new System.Drawing.Point(332, 397);
            this.txt_salaryCycleDurations.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salaryCycleDurations.Name = "txt_salaryCycleDurations";
            this.txt_salaryCycleDurations.Size = new System.Drawing.Size(249, 32);
            this.txt_salaryCycleDurations.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "Salary End Date :";
            // 
            // settingGridView
            // 
            this.settingGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.settingGridView.Location = new System.Drawing.Point(27, 536);
            this.settingGridView.Margin = new System.Windows.Forms.Padding(4);
            this.settingGridView.Name = "settingGridView";
            this.settingGridView.RowHeadersWidth = 51;
            this.settingGridView.Size = new System.Drawing.Size(1000, 238);
            this.settingGridView.TabIndex = 84;
            this.settingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.settingGridView_CellContentClick);
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
            this.btuDelete.Location = new System.Drawing.Point(828, 478);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 91;
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
            this.btuUpdate.Location = new System.Drawing.Point(623, 478);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 90;
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
            this.btuClear.Location = new System.Drawing.Point(623, 412);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 89;
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
            this.btuSave.Location = new System.Drawing.Point(828, 412);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 88;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // datetxt_salaryBeginDate
            // 
            this.datetxt_salaryBeginDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt_salaryBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetxt_salaryBeginDate.Location = new System.Drawing.Point(247, 238);
            this.datetxt_salaryBeginDate.Margin = new System.Windows.Forms.Padding(4);
            this.datetxt_salaryBeginDate.Name = "datetxt_salaryBeginDate";
            this.datetxt_salaryBeginDate.Size = new System.Drawing.Size(334, 34);
            this.datetxt_salaryBeginDate.TabIndex = 93;
            this.datetxt_salaryBeginDate.Value = new System.DateTime(2023, 8, 21, 0, 0, 0, 0);
            // 
            // datetxt_salaryEndDate
            // 
            this.datetxt_salaryEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt_salaryEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetxt_salaryEndDate.Location = new System.Drawing.Point(247, 294);
            this.datetxt_salaryEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.datetxt_salaryEndDate.Name = "datetxt_salaryEndDate";
            this.datetxt_salaryEndDate.Size = new System.Drawing.Size(334, 34);
            this.datetxt_salaryEndDate.TabIndex = 92;
            this.datetxt_salaryEndDate.Value = new System.DateTime(2023, 8, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 94;
            this.label3.Text = "Number of Per Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 32);
            this.label4.TabIndex = 95;
            this.label4.Text = "Salary Cycle Durations :";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetxt_salaryBeginDate);
            this.Controls.Add(this.datetxt_salaryEndDate);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.settingGridView);
            this.Controls.Add(this.txt_salaryCycleDurations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numberOfPerYear);
            this.Controls.Add(this.Salary_Begin_dateLabel);
            this.Controls.Add(this.combo_AdminFk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_settingID);
            this.Controls.Add(this.settingIdlabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label settingTxt;
        private System.Windows.Forms.TextBox txt_settingID;
        private System.Windows.Forms.Label settingIdlabel;
        private System.Windows.Forms.ComboBox combo_AdminFk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numberOfPerYear;
        private System.Windows.Forms.Label Salary_Begin_dateLabel;
        private System.Windows.Forms.TextBox txt_salaryCycleDurations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView settingGridView;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.DateTimePicker datetxt_salaryBeginDate;
        private System.Windows.Forms.DateTimePicker datetxt_salaryEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label6;
    }
}