namespace Project_Grifindo_Toys
{
    partial class experience
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
            this.experTxt = new System.Windows.Forms.Label();
            this.txt_experince_id = new System.Windows.Forms.TextBox();
            this.experText = new System.Windows.Forms.Label();
            this.txt_PreWokingPlace = new System.Windows.Forms.TextBox();
            this.preJobPlaceLabel = new System.Windows.Forms.Label();
            this.combo_EmpFk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workStrtLabel = new System.Windows.Forms.Label();
            this.txt_workend = new System.Windows.Forms.DateTimePicker();
            this.txt_workstart = new System.Windows.Forms.DateTimePicker();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.experienceGridView = new System.Windows.Forms.DataGridView();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experienceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.experTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 25;
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
            this.btnclose.Location = new System.Drawing.Point(999, 6);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 31;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // experTxt
            // 
            this.experTxt.AutoSize = true;
            this.experTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experTxt.ForeColor = System.Drawing.Color.White;
            this.experTxt.Location = new System.Drawing.Point(776, 4);
            this.experTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.experTxt.Name = "experTxt";
            this.experTxt.Size = new System.Drawing.Size(217, 46);
            this.experTxt.TabIndex = 1;
            this.experTxt.Text = "EXPERIENCE";
            // 
            // txt_experince_id
            // 
            this.txt_experince_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_experince_id.Location = new System.Drawing.Point(309, 107);
            this.txt_experince_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_experince_id.Name = "txt_experince_id";
            this.txt_experince_id.Size = new System.Drawing.Size(276, 32);
            this.txt_experince_id.TabIndex = 54;
            // 
            // experText
            // 
            this.experText.AutoSize = true;
            this.experText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experText.ForeColor = System.Drawing.Color.White;
            this.experText.Location = new System.Drawing.Point(116, 104);
            this.experText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.experText.Name = "experText";
            this.experText.Size = new System.Drawing.Size(185, 32);
            this.experText.TabIndex = 53;
            this.experText.Text = "Experience ID :";
            // 
            // txt_PreWokingPlace
            // 
            this.txt_PreWokingPlace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PreWokingPlace.Location = new System.Drawing.Point(309, 207);
            this.txt_PreWokingPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PreWokingPlace.Name = "txt_PreWokingPlace";
            this.txt_PreWokingPlace.Size = new System.Drawing.Size(324, 32);
            this.txt_PreWokingPlace.TabIndex = 56;
            // 
            // preJobPlaceLabel
            // 
            this.preJobPlaceLabel.AutoSize = true;
            this.preJobPlaceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preJobPlaceLabel.ForeColor = System.Drawing.Color.White;
            this.preJobPlaceLabel.Location = new System.Drawing.Point(13, 204);
            this.preJobPlaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preJobPlaceLabel.Name = "preJobPlaceLabel";
            this.preJobPlaceLabel.Size = new System.Drawing.Size(288, 32);
            this.preJobPlaceLabel.TabIndex = 55;
            this.preJobPlaceLabel.Text = "Previous workingplace :";
            // 
            // combo_EmpFk
            // 
            this.combo_EmpFk.FormattingEnabled = true;
            this.combo_EmpFk.Location = new System.Drawing.Point(309, 160);
            this.combo_EmpFk.Name = "combo_EmpFk";
            this.combo_EmpFk.Size = new System.Drawing.Size(276, 24);
            this.combo_EmpFk.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "Employee :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "Work End Date :";
            // 
            // workStrtLabel
            // 
            this.workStrtLabel.AutoSize = true;
            this.workStrtLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workStrtLabel.ForeColor = System.Drawing.Color.White;
            this.workStrtLabel.Location = new System.Drawing.Point(91, 262);
            this.workStrtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workStrtLabel.Name = "workStrtLabel";
            this.workStrtLabel.Size = new System.Drawing.Size(210, 32);
            this.workStrtLabel.TabIndex = 63;
            this.workStrtLabel.Text = "Work Start Date :";
            // 
            // txt_workend
            // 
            this.txt_workend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_workend.Location = new System.Drawing.Point(309, 316);
            this.txt_workend.Margin = new System.Windows.Forms.Padding(4);
            this.txt_workend.Name = "txt_workend";
            this.txt_workend.Size = new System.Drawing.Size(334, 34);
            this.txt_workend.TabIndex = 64;
            this.txt_workend.Value = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            this.txt_workend.ValueChanged += new System.EventHandler(this.txt_workend_ValueChanged);
            // 
            // txt_workstart
            // 
            this.txt_workstart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_workstart.Location = new System.Drawing.Point(309, 260);
            this.txt_workstart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_workstart.Name = "txt_workstart";
            this.txt_workstart.Size = new System.Drawing.Size(334, 34);
            this.txt_workstart.TabIndex = 65;
            this.txt_workstart.Value = new System.DateTime(2023, 6, 2, 0, 0, 0, 0);
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(669, 152);
            this.txt_reason.Margin = new System.Windows.Forms.Padding(4);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(324, 32);
            this.txt_reason.TabIndex = 67;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.ForeColor = System.Drawing.Color.White;
            this.reasonLabel.Location = new System.Drawing.Point(663, 107);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(256, 32);
            this.reasonLabel.TabIndex = 66;
            this.reasonLabel.Text = "Reason of resigning :";
            // 
            // experienceGridView
            // 
            this.experienceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.experienceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.experienceGridView.Location = new System.Drawing.Point(13, 540);
            this.experienceGridView.Margin = new System.Windows.Forms.Padding(4);
            this.experienceGridView.Name = "experienceGridView";
            this.experienceGridView.RowHeadersWidth = 51;
            this.experienceGridView.Size = new System.Drawing.Size(1019, 223);
            this.experienceGridView.TabIndex = 68;
            this.experienceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.experienceGridView_CellContentClick);
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
            this.btuDelete.Location = new System.Drawing.Point(829, 471);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 72;
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
            this.btuUpdate.Location = new System.Drawing.Point(624, 471);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 71;
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
            this.btuClear.Location = new System.Drawing.Point(624, 405);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 70;
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
            this.btuSave.Location = new System.Drawing.Point(829, 405);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 69;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // experience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.experienceGridView);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.txt_workstart);
            this.Controls.Add(this.txt_workend);
            this.Controls.Add(this.workStrtLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_EmpFk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PreWokingPlace);
            this.Controls.Add(this.preJobPlaceLabel);
            this.Controls.Add(this.txt_experince_id);
            this.Controls.Add(this.experText);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "experience";
            this.Text = "experience";
            this.Load += new System.EventHandler(this.experience_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experienceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label experTxt;
        private System.Windows.Forms.TextBox txt_experince_id;
        private System.Windows.Forms.Label experText;
        private System.Windows.Forms.TextBox txt_PreWokingPlace;
        private System.Windows.Forms.Label preJobPlaceLabel;
        private System.Windows.Forms.ComboBox combo_EmpFk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label workStrtLabel;
        private System.Windows.Forms.DateTimePicker txt_workend;
        private System.Windows.Forms.DateTimePicker txt_workstart;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.DataGridView experienceGridView;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.Button btnclose;
    }
}