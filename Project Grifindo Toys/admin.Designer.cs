namespace Project_Grifindo_Toys
{
    partial class admin
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
            this.adminTxt = new System.Windows.Forms.Label();
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.adminIDlabel = new System.Windows.Forms.Label();
            this.txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.genderNameLabel = new System.Windows.Forms.Label();
            this.txt_AdminUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btuDelete = new System.Windows.Forms.Button();
            this.btuUpdate = new System.Windows.Forms.Button();
            this.btuClear = new System.Windows.Forms.Button();
            this.btuSave = new System.Windows.Forms.Button();
            this.adminGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.adminTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 58);
            this.panel1.TabIndex = 31;
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
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // adminTxt
            // 
            this.adminTxt.AutoSize = true;
            this.adminTxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTxt.ForeColor = System.Drawing.Color.White;
            this.adminTxt.Location = new System.Drawing.Point(854, 3);
            this.adminTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminTxt.Name = "adminTxt";
            this.adminTxt.Size = new System.Drawing.Size(140, 46);
            this.adminTxt.TabIndex = 1;
            this.adminTxt.Text = "ADMIN";
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminID.Location = new System.Drawing.Point(213, 131);
            this.txt_AdminID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.Size = new System.Drawing.Size(276, 32);
            this.txt_AdminID.TabIndex = 64;
            // 
            // adminIDlabel
            // 
            this.adminIDlabel.AutoSize = true;
            this.adminIDlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIDlabel.ForeColor = System.Drawing.Color.White;
            this.adminIDlabel.Location = new System.Drawing.Point(58, 131);
            this.adminIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminIDlabel.Name = "adminIDlabel";
            this.adminIDlabel.Size = new System.Drawing.Size(137, 32);
            this.adminIDlabel.TabIndex = 63;
            this.adminIDlabel.Text = "Admin ID :";
            // 
            // txt_AdminPassword
            // 
            this.txt_AdminPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword.Location = new System.Drawing.Point(213, 252);
            this.txt_AdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminPassword.Name = "txt_AdminPassword";
            this.txt_AdminPassword.Size = new System.Drawing.Size(276, 32);
            this.txt_AdminPassword.TabIndex = 68;
            // 
            // genderNameLabel
            // 
            this.genderNameLabel.AutoSize = true;
            this.genderNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderNameLabel.ForeColor = System.Drawing.Color.White;
            this.genderNameLabel.Location = new System.Drawing.Point(59, 249);
            this.genderNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderNameLabel.Name = "genderNameLabel";
            this.genderNameLabel.Size = new System.Drawing.Size(136, 32);
            this.genderNameLabel.TabIndex = 67;
            this.genderNameLabel.Text = "Password :";
            // 
            // txt_AdminUserName
            // 
            this.txt_AdminUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminUserName.Location = new System.Drawing.Point(213, 194);
            this.txt_AdminUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminUserName.Name = "txt_AdminUserName";
            this.txt_AdminUserName.Size = new System.Drawing.Size(276, 32);
            this.txt_AdminUserName.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "User Name :";
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
            this.btuDelete.Location = new System.Drawing.Point(830, 468);
            this.btuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btuDelete.Name = "btuDelete";
            this.btuDelete.Size = new System.Drawing.Size(164, 37);
            this.btuDelete.TabIndex = 99;
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
            this.btuUpdate.Location = new System.Drawing.Point(625, 468);
            this.btuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btuUpdate.Name = "btuUpdate";
            this.btuUpdate.Size = new System.Drawing.Size(164, 37);
            this.btuUpdate.TabIndex = 98;
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
            this.btuClear.Location = new System.Drawing.Point(625, 402);
            this.btuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btuClear.Name = "btuClear";
            this.btuClear.Size = new System.Drawing.Size(164, 37);
            this.btuClear.TabIndex = 97;
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
            this.btuSave.Location = new System.Drawing.Point(830, 402);
            this.btuSave.Margin = new System.Windows.Forms.Padding(4);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(164, 37);
            this.btuSave.TabIndex = 96;
            this.btuSave.Text = "SAVE";
            this.btuSave.UseVisualStyleBackColor = false;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // adminGridView
            // 
            this.adminGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGridView.Location = new System.Drawing.Point(17, 536);
            this.adminGridView.Margin = new System.Windows.Forms.Padding(4);
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.RowHeadersWidth = 51;
            this.adminGridView.Size = new System.Drawing.Size(1035, 344);
            this.adminGridView.TabIndex = 100;
            this.adminGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGridView_CellContentClick);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 787);
            this.Controls.Add(this.adminGridView);
            this.Controls.Add(this.btuDelete);
            this.Controls.Add(this.btuUpdate);
            this.Controls.Add(this.btuClear);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.txt_AdminUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AdminPassword);
            this.Controls.Add(this.genderNameLabel);
            this.Controls.Add(this.txt_AdminID);
            this.Controls.Add(this.adminIDlabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label adminTxt;
        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.Label adminIDlabel;
        private System.Windows.Forms.TextBox txt_AdminPassword;
        private System.Windows.Forms.Label genderNameLabel;
        private System.Windows.Forms.TextBox txt_AdminUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btuDelete;
        private System.Windows.Forms.Button btuUpdate;
        private System.Windows.Forms.Button btuClear;
        private System.Windows.Forms.Button btuSave;
        private System.Windows.Forms.DataGridView adminGridView;
        private System.Windows.Forms.Button btnclose;
    }
}