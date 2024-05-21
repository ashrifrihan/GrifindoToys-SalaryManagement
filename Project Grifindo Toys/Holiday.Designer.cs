namespace Project_Grifindo_Toys
{
    partial class Holiday
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
            this.holidayTxt = new System.Windows.Forms.Label();
            this.txt_holidayID = new System.Windows.Forms.TextBox();
            this.appliedleavelabel = new System.Windows.Forms.Label();
            this.txt_CountHoliday = new System.Windows.Forms.TextBox();
            this.annualLeaveLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.holidatGridView = new System.Windows.Forms.DataGridView();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidatGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.holidayTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 29;
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
            this.btnclose.Location = new System.Drawing.Point(1000, 6);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // holidayTxt
            // 
            this.holidayTxt.AutoSize = true;
            this.holidayTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayTxt.ForeColor = System.Drawing.Color.White;
            this.holidayTxt.Location = new System.Drawing.Point(821, 4);
            this.holidayTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holidayTxt.Name = "holidayTxt";
            this.holidayTxt.Size = new System.Drawing.Size(166, 46);
            this.holidayTxt.TabIndex = 1;
            this.holidayTxt.Text = "HOLIDAY";
            // 
            // txt_holidayID
            // 
            this.txt_holidayID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_holidayID.Location = new System.Drawing.Point(245, 132);
            this.txt_holidayID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_holidayID.Name = "txt_holidayID";
            this.txt_holidayID.Size = new System.Drawing.Size(276, 32);
            this.txt_holidayID.TabIndex = 62;
            // 
            // appliedleavelabel
            // 
            this.appliedleavelabel.AutoSize = true;
            this.appliedleavelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedleavelabel.ForeColor = System.Drawing.Color.White;
            this.appliedleavelabel.Location = new System.Drawing.Point(87, 132);
            this.appliedleavelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appliedleavelabel.Name = "appliedleavelabel";
            this.appliedleavelabel.Size = new System.Drawing.Size(149, 32);
            this.appliedleavelabel.TabIndex = 61;
            this.appliedleavelabel.Text = "Holiday ID :";
            // 
            // txt_CountHoliday
            // 
            this.txt_CountHoliday.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CountHoliday.Location = new System.Drawing.Point(245, 191);
            this.txt_CountHoliday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CountHoliday.Name = "txt_CountHoliday";
            this.txt_CountHoliday.Size = new System.Drawing.Size(276, 32);
            this.txt_CountHoliday.TabIndex = 72;
            // 
            // annualLeaveLabel
            // 
            this.annualLeaveLabel.AutoSize = true;
            this.annualLeaveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualLeaveLabel.ForeColor = System.Drawing.Color.White;
            this.annualLeaveLabel.Location = new System.Drawing.Point(13, 188);
            this.annualLeaveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.annualLeaveLabel.Name = "annualLeaveLabel";
            this.annualLeaveLabel.Size = new System.Drawing.Size(223, 32);
            this.annualLeaveLabel.TabIndex = 71;
            this.annualLeaveLabel.Text = "Count of Holiday :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "Month :";
            // 
            // holidatGridView
            // 
            this.holidatGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.holidatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidatGridView.Location = new System.Drawing.Point(28, 536);
            this.holidatGridView.Margin = new System.Windows.Forms.Padding(4);
            this.holidatGridView.Name = "holidatGridView";
            this.holidatGridView.RowHeadersWidth = 51;
            this.holidatGridView.Size = new System.Drawing.Size(987, 238);
            this.holidatGridView.TabIndex = 84;
            this.holidatGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidatGridView_CellContentClick);
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
            this.btuDelete.Location = new System.Drawing.Point(829, 470);
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
            this.btuUpdate.Location = new System.Drawing.Point(624, 470);
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
            this.btuClear.Location = new System.Drawing.Point(624, 404);
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
            this.btuSave.Location = new System.Drawing.Point(829, 404);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 88;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.CustomFormat = "MM/dd/yyy ";
            this.monthTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthTextBox.Location = new System.Drawing.Point(245, 246);
            this.monthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(276, 34);
            this.monthTextBox.TabIndex = 93;
            this.monthTextBox.Value = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // Holiday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.holidatGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CountHoliday);
            this.Controls.Add(this.annualLeaveLabel);
            this.Controls.Add(this.txt_holidayID);
            this.Controls.Add(this.appliedleavelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Holiday";
            this.Text = "Holiday";
            this.Load += new System.EventHandler(this.Holiday_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidatGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label holidayTxt;
        private System.Windows.Forms.TextBox txt_holidayID;
        private System.Windows.Forms.Label appliedleavelabel;
        private System.Windows.Forms.TextBox txt_CountHoliday;
        private System.Windows.Forms.Label annualLeaveLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView holidatGridView;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker monthTextBox;
    }
}