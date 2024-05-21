namespace Project_Grifindo_Toys
{
    partial class login
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
            this.appliedleavelabel = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_Btu = new System.Windows.Forms.Button();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // appliedleavelabel
            // 
            this.appliedleavelabel.AutoSize = true;
            this.appliedleavelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedleavelabel.ForeColor = System.Drawing.Color.White;
            this.appliedleavelabel.Location = new System.Drawing.Point(81, 136);
            this.appliedleavelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appliedleavelabel.Name = "appliedleavelabel";
            this.appliedleavelabel.Size = new System.Drawing.Size(139, 32);
            this.appliedleavelabel.TabIndex = 62;
            this.appliedleavelabel.Text = "User Name";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(87, 172);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(356, 32);
            this.txt_userName.TabIndex = 75;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(87, 275);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(356, 32);
            this.txt_password.TabIndex = 77;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "Password";
            // 
            // login_Btu
            // 
            this.login_Btu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.login_Btu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_Btu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.login_Btu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_Btu.Location = new System.Drawing.Point(108, 390);
            this.login_Btu.Name = "login_Btu";
            this.login_Btu.Size = new System.Drawing.Size(316, 53);
            this.login_Btu.TabIndex = 78;
            this.login_Btu.Text = "Login";
            this.login_Btu.UseVisualStyleBackColor = false;
            this.login_Btu.Click += new System.EventHandler(this.login_Btu_Click);
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_Show.Location = new System.Drawing.Point(87, 324);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(162, 29);
            this.checkBox_Show.TabIndex = 79;
            this.checkBox_Show.Text = "Show Password";
            this.checkBox_Show.UseVisualStyleBackColor = true;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(534, 547);
            this.Controls.Add(this.checkBox_Show);
            this.Controls.Add(this.login_Btu);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.appliedleavelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label appliedleavelabel;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_Btu;
        private System.Windows.Forms.CheckBox checkBox_Show;
    }
}