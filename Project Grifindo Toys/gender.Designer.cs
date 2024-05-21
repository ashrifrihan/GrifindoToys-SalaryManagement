namespace Project_Grifindo_Toys
{
    partial class gender
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
            this.genderTxt = new System.Windows.Forms.Label();
            this.txt_genderID = new System.Windows.Forms.TextBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.txt_genderName = new System.Windows.Forms.TextBox();
            this.genderNameLabel = new System.Windows.Forms.Label();
            this.genderGridView = new System.Windows.Forms.DataGridView();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.genderTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 30;
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
            this.btnclose.Location = new System.Drawing.Point(999, 5);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 31;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // genderTxt
            // 
            this.genderTxt.AutoSize = true;
            this.genderTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxt.ForeColor = System.Drawing.Color.White;
            this.genderTxt.Location = new System.Drawing.Point(840, 3);
            this.genderTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(154, 46);
            this.genderTxt.TabIndex = 1;
            this.genderTxt.Text = "GENDER";
            // 
            // txt_genderID
            // 
            this.txt_genderID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genderID.Location = new System.Drawing.Point(275, 156);
            this.txt_genderID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_genderID.Name = "txt_genderID";
            this.txt_genderID.Size = new System.Drawing.Size(276, 32);
            this.txt_genderID.TabIndex = 64;
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.ForeColor = System.Drawing.Color.White;
            this.genderlabel.Location = new System.Drawing.Point(108, 156);
            this.genderlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(144, 32);
            this.genderlabel.TabIndex = 63;
            this.genderlabel.Text = "Gender ID :";
            // 
            // txt_genderName
            // 
            this.txt_genderName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genderName.Location = new System.Drawing.Point(275, 209);
            this.txt_genderName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_genderName.Name = "txt_genderName";
            this.txt_genderName.Size = new System.Drawing.Size(276, 32);
            this.txt_genderName.TabIndex = 66;
            // 
            // genderNameLabel
            // 
            this.genderNameLabel.AutoSize = true;
            this.genderNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderNameLabel.ForeColor = System.Drawing.Color.White;
            this.genderNameLabel.Location = new System.Drawing.Point(67, 206);
            this.genderNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderNameLabel.Name = "genderNameLabel";
            this.genderNameLabel.Size = new System.Drawing.Size(185, 32);
            this.genderNameLabel.TabIndex = 65;
            this.genderNameLabel.Text = "Gender Name :";
            // 
            // genderGridView
            // 
            this.genderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genderGridView.Location = new System.Drawing.Point(29, 536);
            this.genderGridView.Margin = new System.Windows.Forms.Padding(4);
            this.genderGridView.Name = "genderGridView";
            this.genderGridView.RowHeadersWidth = 51;
            this.genderGridView.Size = new System.Drawing.Size(988, 238);
            this.genderGridView.TabIndex = 85;
            this.genderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genderGridView_CellContentClick);
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
            this.btuDelete.Location = new System.Drawing.Point(827, 474);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 95;
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
            this.btuUpdate.Location = new System.Drawing.Point(622, 474);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 94;
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
            this.btuClear.Location = new System.Drawing.Point(622, 408);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 93;
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
            this.btuSave.Location = new System.Drawing.Point(827, 408);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 92;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // gender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.genderGridView);
            this.Controls.Add(this.txt_genderName);
            this.Controls.Add(this.genderNameLabel);
            this.Controls.Add(this.txt_genderID);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gender";
            this.Text = "gender";
            this.Load += new System.EventHandler(this.gender_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label genderTxt;
        private System.Windows.Forms.TextBox txt_genderID;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.TextBox txt_genderName;
        private System.Windows.Forms.Label genderNameLabel;
        private System.Windows.Forms.DataGridView genderGridView;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.Button btnclose;
    }
}