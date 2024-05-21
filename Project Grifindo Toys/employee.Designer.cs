namespace Project_Grifindo_Toys
{
    partial class employee
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
            this.empTxt = new System.Windows.Forms.Label();
            this.emplable = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.empAddLabel = new System.Windows.Forms.Label();
            this.empNumberLabel = new System.Windows.Forms.Label();
            this.empMonthSal = new System.Windows.Forms.Label();
            this.txt_EmpOverTimeRate = new System.Windows.Forms.TextBox();
            this.txt_EmpMonthSal = new System.Windows.Forms.TextBox();
            this.txt_EmpMobNumber = new System.Windows.Forms.TextBox();
            this.txt_EmpAdd = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.overTimeRateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.comBox_GenderFk = new System.Windows.Forms.ComboBox();
            this.levCountLabel = new System.Windows.Forms.Label();
            this.txt_EmpWorkDays = new System.Windows.Forms.TextBox();
            this.EmpWorkDays = new System.Windows.Forms.Label();
            this.comBox_LeaveCountFk = new System.Windows.Forms.ComboBox();
            this.allowenceLabel = new System.Windows.Forms.Label();
            this.txt_EmpAllowence = new System.Windows.Forms.TextBox();
            this.btuSave = new System.Windows.Forms.Button();
            this.empGridView = new System.Windows.Forms.DataGridView();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuDelete = new System.Windows.Forms.Button();
            this.comBox_AdminFk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.empTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 23;
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
            this.btnclose.Location = new System.Drawing.Point(999, 7);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 53;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // empTxt
            // 
            this.empTxt.AutoSize = true;
            this.empTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTxt.ForeColor = System.Drawing.Color.White;
            this.empTxt.Location = new System.Drawing.Point(799, 7);
            this.empTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empTxt.Name = "empTxt";
            this.empTxt.Size = new System.Drawing.Size(190, 46);
            this.empTxt.TabIndex = 1;
            this.empTxt.Text = "EMPLOYEE";
            // 
            // emplable
            // 
            this.emplable.AutoSize = true;
            this.emplable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplable.ForeColor = System.Drawing.Color.White;
            this.emplable.Location = new System.Drawing.Point(48, 116);
            this.emplable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emplable.Name = "emplable";
            this.emplable.Size = new System.Drawing.Size(172, 32);
            this.emplable.TabIndex = 24;
            this.emplable.Text = "Employee ID :";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpID.Location = new System.Drawing.Point(228, 116);
            this.txt_EmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(276, 32);
            this.txt_EmpID.TabIndex = 25;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(125, 171);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(95, 32);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Name :";
            // 
            // empAddLabel
            // 
            this.empAddLabel.AutoSize = true;
            this.empAddLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddLabel.ForeColor = System.Drawing.Color.White;
            this.empAddLabel.Location = new System.Drawing.Point(100, 225);
            this.empAddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empAddLabel.Name = "empAddLabel";
            this.empAddLabel.Size = new System.Drawing.Size(120, 32);
            this.empAddLabel.TabIndex = 28;
            this.empAddLabel.Text = "Address :";
            // 
            // empNumberLabel
            // 
            this.empNumberLabel.AutoSize = true;
            this.empNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNumberLabel.ForeColor = System.Drawing.Color.White;
            this.empNumberLabel.Location = new System.Drawing.Point(11, 283);
            this.empNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empNumberLabel.Name = "empNumberLabel";
            this.empNumberLabel.Size = new System.Drawing.Size(209, 32);
            this.empNumberLabel.TabIndex = 30;
            this.empNumberLabel.Text = "Mobile Number :";
            // 
            // empMonthSal
            // 
            this.empMonthSal.AutoSize = true;
            this.empMonthSal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empMonthSal.ForeColor = System.Drawing.Color.White;
            this.empMonthSal.Location = new System.Drawing.Point(28, 338);
            this.empMonthSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empMonthSal.Name = "empMonthSal";
            this.empMonthSal.Size = new System.Drawing.Size(192, 32);
            this.empMonthSal.TabIndex = 32;
            this.empMonthSal.Text = "Months Salary :";
            // 
            // txt_EmpOverTimeRate
            // 
            this.txt_EmpOverTimeRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpOverTimeRate.Location = new System.Drawing.Point(752, 174);
            this.txt_EmpOverTimeRate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpOverTimeRate.Name = "txt_EmpOverTimeRate";
            this.txt_EmpOverTimeRate.Size = new System.Drawing.Size(210, 32);
            this.txt_EmpOverTimeRate.TabIndex = 33;
            // 
            // txt_EmpMonthSal
            // 
            this.txt_EmpMonthSal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpMonthSal.Location = new System.Drawing.Point(228, 341);
            this.txt_EmpMonthSal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpMonthSal.Name = "txt_EmpMonthSal";
            this.txt_EmpMonthSal.Size = new System.Drawing.Size(300, 32);
            this.txt_EmpMonthSal.TabIndex = 34;
            // 
            // txt_EmpMobNumber
            // 
            this.txt_EmpMobNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpMobNumber.Location = new System.Drawing.Point(228, 286);
            this.txt_EmpMobNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpMobNumber.Name = "txt_EmpMobNumber";
            this.txt_EmpMobNumber.Size = new System.Drawing.Size(300, 32);
            this.txt_EmpMobNumber.TabIndex = 35;
            // 
            // txt_EmpAdd
            // 
            this.txt_EmpAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAdd.Location = new System.Drawing.Point(228, 228);
            this.txt_EmpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpAdd.Name = "txt_EmpAdd";
            this.txt_EmpAdd.Size = new System.Drawing.Size(300, 32);
            this.txt_EmpAdd.TabIndex = 36;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpName.Location = new System.Drawing.Point(228, 174);
            this.txt_EmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(300, 32);
            this.txt_EmpName.TabIndex = 37;
            // 
            // overTimeRateLabel
            // 
            this.overTimeRateLabel.AutoSize = true;
            this.overTimeRateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overTimeRateLabel.ForeColor = System.Drawing.Color.White;
            this.overTimeRateLabel.Location = new System.Drawing.Point(551, 174);
            this.overTimeRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overTimeRateLabel.Name = "overTimeRateLabel";
            this.overTimeRateLabel.Size = new System.Drawing.Size(190, 32);
            this.overTimeRateLabel.TabIndex = 38;
            this.overTimeRateLabel.Text = "Over Timerate :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(630, 113);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(111, 32);
            this.genderLabel.TabIndex = 39;
            this.genderLabel.Text = "Gender :";
            // 
            // comBox_GenderFk
            // 
            this.comBox_GenderFk.FormattingEnabled = true;
            this.comBox_GenderFk.Location = new System.Drawing.Point(752, 120);
            this.comBox_GenderFk.Name = "comBox_GenderFk";
            this.comBox_GenderFk.Size = new System.Drawing.Size(157, 24);
            this.comBox_GenderFk.TabIndex = 40;
            // 
            // levCountLabel
            // 
            this.levCountLabel.AutoSize = true;
            this.levCountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levCountLabel.ForeColor = System.Drawing.Color.White;
            this.levCountLabel.Location = new System.Drawing.Point(574, 225);
            this.levCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levCountLabel.Name = "levCountLabel";
            this.levCountLabel.Size = new System.Drawing.Size(168, 32);
            this.levCountLabel.TabIndex = 41;
            this.levCountLabel.Text = "Leave Count :";
            // 
            // txt_EmpWorkDays
            // 
            this.txt_EmpWorkDays.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpWorkDays.Location = new System.Drawing.Point(810, 283);
            this.txt_EmpWorkDays.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpWorkDays.Name = "txt_EmpWorkDays";
            this.txt_EmpWorkDays.Size = new System.Drawing.Size(210, 32);
            this.txt_EmpWorkDays.TabIndex = 43;
            // 
            // EmpWorkDays
            // 
            this.EmpWorkDays.AutoSize = true;
            this.EmpWorkDays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpWorkDays.ForeColor = System.Drawing.Color.White;
            this.EmpWorkDays.Location = new System.Drawing.Point(547, 280);
            this.EmpWorkDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpWorkDays.Name = "EmpWorkDays";
            this.EmpWorkDays.Size = new System.Drawing.Size(248, 32);
            this.EmpWorkDays.TabIndex = 44;
            this.EmpWorkDays.Text = "Employee Workday :";
            // 
            // comBox_LeaveCountFk
            // 
            this.comBox_LeaveCountFk.FormattingEnabled = true;
            this.comBox_LeaveCountFk.Location = new System.Drawing.Point(752, 228);
            this.comBox_LeaveCountFk.Name = "comBox_LeaveCountFk";
            this.comBox_LeaveCountFk.Size = new System.Drawing.Size(240, 24);
            this.comBox_LeaveCountFk.TabIndex = 45;
            // 
            // allowenceLabel
            // 
            this.allowenceLabel.AutoSize = true;
            this.allowenceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowenceLabel.ForeColor = System.Drawing.Color.White;
            this.allowenceLabel.Location = new System.Drawing.Point(598, 338);
            this.allowenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allowenceLabel.Name = "allowenceLabel";
            this.allowenceLabel.Size = new System.Drawing.Size(146, 32);
            this.allowenceLabel.TabIndex = 46;
            this.allowenceLabel.Text = "Allowence :";
            // 
            // txt_EmpAllowence
            // 
            this.txt_EmpAllowence.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAllowence.Location = new System.Drawing.Point(752, 338);
            this.txt_EmpAllowence.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmpAllowence.Name = "txt_EmpAllowence";
            this.txt_EmpAllowence.Size = new System.Drawing.Size(240, 32);
            this.txt_EmpAllowence.TabIndex = 47;
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
            this.btuSave.Location = new System.Drawing.Point(828, 410);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 48;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // empGridView
            // 
            this.empGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGridView.Location = new System.Drawing.Point(19, 542);
            this.empGridView.Margin = new System.Windows.Forms.Padding(4);
            this.empGridView.Name = "empGridView";
            this.empGridView.RowHeadersWidth = 51;
            this.empGridView.Size = new System.Drawing.Size(1001, 229);
            this.empGridView.TabIndex = 49;
            this.empGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empGridView_CellContentClick);
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
            this.btuClear.Location = new System.Drawing.Point(623, 410);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 50;
            this.btuClear.Text = "CLEAR";
            this.btuClear.UseVisualStyleBackColor = false;
            this.btuClear.Click += new System.EventHandler(this.btuClear_Click);
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
            this.btuUpdate.Location = new System.Drawing.Point(623, 476);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 51;
            this.btuUpdate.Text = "UPDATE";
            this.btuUpdate.UseVisualStyleBackColor = false;
            this.btuUpdate.Click += new System.EventHandler(this.btuUpdate_Click);
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
            this.btuDelete.Location = new System.Drawing.Point(828, 476);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 52;
            this.btuDelete.Text = "DELETE";
            this.btuDelete.UseVisualStyleBackColor = false;
            this.btuDelete.Click += new System.EventHandler(this.btuDelete_Click);
            // 
            // comBox_AdminFk
            // 
            this.comBox_AdminFk.FormattingEnabled = true;
            this.comBox_AdminFk.Location = new System.Drawing.Point(228, 390);
            this.comBox_AdminFk.Name = "comBox_AdminFk";
            this.comBox_AdminFk.Size = new System.Drawing.Size(300, 24);
            this.comBox_AdminFk.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Admin :";
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.comBox_AdminFk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.empGridView);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.txt_EmpAllowence);
            this.Controls.Add(this.allowenceLabel);
            this.Controls.Add(this.comBox_LeaveCountFk);
            this.Controls.Add(this.EmpWorkDays);
            this.Controls.Add(this.txt_EmpWorkDays);
            this.Controls.Add(this.levCountLabel);
            this.Controls.Add(this.comBox_GenderFk);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.overTimeRateLabel);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.txt_EmpAdd);
            this.Controls.Add(this.txt_EmpMobNumber);
            this.Controls.Add(this.txt_EmpMonthSal);
            this.Controls.Add(this.txt_EmpOverTimeRate);
            this.Controls.Add(this.empMonthSal);
            this.Controls.Add(this.empNumberLabel);
            this.Controls.Add(this.empAddLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.emplable);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label empTxt;
        private System.Windows.Forms.Label emplable;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label empAddLabel;
        private System.Windows.Forms.Label empNumberLabel;
        private System.Windows.Forms.Label empMonthSal;
        private System.Windows.Forms.TextBox txt_EmpOverTimeRate;
        private System.Windows.Forms.TextBox txt_EmpMonthSal;
        private System.Windows.Forms.TextBox txt_EmpMobNumber;
        private System.Windows.Forms.TextBox txt_EmpAdd;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.Label overTimeRateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox comBox_GenderFk;
        private System.Windows.Forms.Label levCountLabel;
        private System.Windows.Forms.TextBox txt_EmpWorkDays;
        private System.Windows.Forms.Label EmpWorkDays;
        private System.Windows.Forms.ComboBox comBox_LeaveCountFk;
        private System.Windows.Forms.Label allowenceLabel;
        private System.Windows.Forms.TextBox txt_EmpAllowence;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.DataGridView empGridView;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox comBox_AdminFk;
        private System.Windows.Forms.Label label1;
    }
}