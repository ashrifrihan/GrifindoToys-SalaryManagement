namespace Project_Grifindo_Toys
{
    partial class salary
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
            this.salaryTxt = new System.Windows.Forms.Label();
            this.txt_salaryID = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.Label();
            this.txt_monthSal = new System.Windows.Forms.TextBox();
            this.monthsalaryLabel = new System.Windows.Forms.Label();
            this.ovrTimeRateLabel = new System.Windows.Forms.Label();
            this.txt_Ovrtimerate = new System.Windows.Forms.TextBox();
            this.txt_basePay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_grossPay = new System.Windows.Forms.TextBox();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.combo_EmpFk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_noPay = new System.Windows.Forms.TextBox();
            this.nopaydurationLabel = new System.Windows.Forms.Label();
            this.combo_holidayFk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.salaryGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total_leave_days_count = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.salaryTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 26;
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
            this.btnclose.Location = new System.Drawing.Point(995, 6);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 78;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // salaryTxt
            // 
            this.salaryTxt.AutoSize = true;
            this.salaryTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTxt.ForeColor = System.Drawing.Color.White;
            this.salaryTxt.Location = new System.Drawing.Point(840, 4);
            this.salaryTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(148, 46);
            this.salaryTxt.TabIndex = 1;
            this.salaryTxt.Text = "SALARY";
            // 
            // txt_salaryID
            // 
            this.txt_salaryID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaryID.Location = new System.Drawing.Point(248, 112);
            this.txt_salaryID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salaryID.Name = "txt_salaryID";
            this.txt_salaryID.Size = new System.Drawing.Size(276, 32);
            this.txt_salaryID.TabIndex = 56;
            // 
            // salaryText
            // 
            this.salaryText.AutoSize = true;
            this.salaryText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryText.ForeColor = System.Drawing.Color.White;
            this.salaryText.Location = new System.Drawing.Point(109, 112);
            this.salaryText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(131, 32);
            this.salaryText.TabIndex = 55;
            this.salaryText.Text = "Salary ID :";
            // 
            // txt_monthSal
            // 
            this.txt_monthSal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthSal.Location = new System.Drawing.Point(248, 174);
            this.txt_monthSal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_monthSal.Name = "txt_monthSal";
            this.txt_monthSal.Size = new System.Drawing.Size(276, 32);
            this.txt_monthSal.TabIndex = 58;
            // 
            // monthsalaryLabel
            // 
            this.monthsalaryLabel.AutoSize = true;
            this.monthsalaryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsalaryLabel.ForeColor = System.Drawing.Color.White;
            this.monthsalaryLabel.Location = new System.Drawing.Point(59, 171);
            this.monthsalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthsalaryLabel.Name = "monthsalaryLabel";
            this.monthsalaryLabel.Size = new System.Drawing.Size(181, 32);
            this.monthsalaryLabel.TabIndex = 57;
            this.monthsalaryLabel.Text = "Month Salary :";
            // 
            // ovrTimeRateLabel
            // 
            this.ovrTimeRateLabel.AutoSize = true;
            this.ovrTimeRateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ovrTimeRateLabel.ForeColor = System.Drawing.Color.White;
            this.ovrTimeRateLabel.Location = new System.Drawing.Point(37, 230);
            this.ovrTimeRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ovrTimeRateLabel.Name = "ovrTimeRateLabel";
            this.ovrTimeRateLabel.Size = new System.Drawing.Size(203, 32);
            this.ovrTimeRateLabel.TabIndex = 59;
            this.ovrTimeRateLabel.Text = "Over Time Rate :";
            // 
            // txt_Ovrtimerate
            // 
            this.txt_Ovrtimerate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ovrtimerate.Location = new System.Drawing.Point(248, 233);
            this.txt_Ovrtimerate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ovrtimerate.Name = "txt_Ovrtimerate";
            this.txt_Ovrtimerate.Size = new System.Drawing.Size(276, 32);
            this.txt_Ovrtimerate.TabIndex = 60;
            // 
            // txt_basePay
            // 
            this.txt_basePay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_basePay.Location = new System.Drawing.Point(248, 291);
            this.txt_basePay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_basePay.Name = "txt_basePay";
            this.txt_basePay.Size = new System.Drawing.Size(276, 32);
            this.txt_basePay.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Base Pay :";
            // 
            // txt_grossPay
            // 
            this.txt_grossPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grossPay.Location = new System.Drawing.Point(712, 112);
            this.txt_grossPay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_grossPay.Name = "txt_grossPay";
            this.txt_grossPay.Size = new System.Drawing.Size(299, 32);
            this.txt_grossPay.TabIndex = 64;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayLabel.ForeColor = System.Drawing.Color.White;
            this.grossPayLabel.Location = new System.Drawing.Point(573, 109);
            this.grossPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(139, 32);
            this.grossPayLabel.TabIndex = 63;
            this.grossPayLabel.Text = "Gross Pay :";
            // 
            // combo_EmpFk
            // 
            this.combo_EmpFk.FormattingEnabled = true;
            this.combo_EmpFk.Location = new System.Drawing.Point(712, 174);
            this.combo_EmpFk.Name = "combo_EmpFk";
            this.combo_EmpFk.Size = new System.Drawing.Size(299, 24);
            this.combo_EmpFk.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(573, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Employee :";
            // 
            // txt_noPay
            // 
            this.txt_noPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noPay.Location = new System.Drawing.Point(775, 231);
            this.txt_noPay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noPay.Name = "txt_noPay";
            this.txt_noPay.Size = new System.Drawing.Size(236, 32);
            this.txt_noPay.TabIndex = 68;
            // 
            // nopaydurationLabel
            // 
            this.nopaydurationLabel.AutoSize = true;
            this.nopaydurationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopaydurationLabel.ForeColor = System.Drawing.Color.White;
            this.nopaydurationLabel.Location = new System.Drawing.Point(549, 228);
            this.nopaydurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nopaydurationLabel.Name = "nopaydurationLabel";
            this.nopaydurationLabel.Size = new System.Drawing.Size(218, 32);
            this.nopaydurationLabel.TabIndex = 67;
            this.nopaydurationLabel.Text = "No Pay Duration :";
            // 
            // combo_holidayFk
            // 
            this.combo_holidayFk.FormattingEnabled = true;
            this.combo_holidayFk.Location = new System.Drawing.Point(740, 291);
            this.combo_holidayFk.Name = "combo_holidayFk";
            this.combo_holidayFk.Size = new System.Drawing.Size(271, 24);
            this.combo_holidayFk.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 69;
            this.label3.Text = "No of Holiday :";
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
            this.btuDelete.Location = new System.Drawing.Point(830, 471);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 77;
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
            this.btuUpdate.Location = new System.Drawing.Point(625, 471);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 76;
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
            this.btuClear.Location = new System.Drawing.Point(625, 405);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 75;
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
            this.btuSave.Location = new System.Drawing.Point(830, 405);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 74;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // salaryGridView
            // 
            this.salaryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGridView.Location = new System.Drawing.Point(18, 541);
            this.salaryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.salaryGridView.Name = "salaryGridView";
            this.salaryGridView.RowHeadersWidth = 51;
            this.salaryGridView.Size = new System.Drawing.Size(1013, 222);
            this.salaryGridView.TabIndex = 73;
            this.salaryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 32);
            this.label5.TabIndex = 100;
            this.label5.Text = "Total leave days count :";
            // 
            // txt_total_leave_days_count
            // 
            this.txt_total_leave_days_count.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_leave_days_count.Location = new System.Drawing.Point(303, 341);
            this.txt_total_leave_days_count.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total_leave_days_count.Name = "txt_total_leave_days_count";
            this.txt_total_leave_days_count.Size = new System.Drawing.Size(221, 32);
            this.txt_total_leave_days_count.TabIndex = 99;
            // 
            // salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_total_leave_days_count);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.salaryGridView);
            this.Controls.Add(this.combo_holidayFk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_noPay);
            this.Controls.Add(this.nopaydurationLabel);
            this.Controls.Add(this.combo_EmpFk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_grossPay);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.txt_basePay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ovrtimerate);
            this.Controls.Add(this.ovrTimeRateLabel);
            this.Controls.Add(this.txt_monthSal);
            this.Controls.Add(this.monthsalaryLabel);
            this.Controls.Add(this.txt_salaryID);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salary";
            this.Text = "salary";
            this.Load += new System.EventHandler(this.salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salaryTxt;
        private System.Windows.Forms.TextBox txt_salaryID;
        private System.Windows.Forms.Label salaryText;
        private System.Windows.Forms.TextBox txt_monthSal;
        private System.Windows.Forms.Label monthsalaryLabel;
        private System.Windows.Forms.Label ovrTimeRateLabel;
        private System.Windows.Forms.TextBox txt_Ovrtimerate;
        private System.Windows.Forms.TextBox txt_basePay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_grossPay;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.ComboBox combo_EmpFk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_noPay;
        private System.Windows.Forms.Label nopaydurationLabel;
        private System.Windows.Forms.ComboBox combo_holidayFk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.DataGridView salaryGridView;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total_leave_days_count;
    }
}