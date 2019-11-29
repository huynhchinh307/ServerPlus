namespace TestUiDemo
{
    partial class ThemThanhVien
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
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(89, 126);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Thêm vào";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(18, 32);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Tên đăng nhập:";
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(18, 84);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(55, 13);
            this.lbl_passwd.TabIndex = 2;
            this.lbl_passwd.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(108, 81);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(144, 20);
            this.txtPasswd.TabIndex = 4;
            // 
            // ThemThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 154);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_register);
            this.Name = "ThemThanhVien";
            this.Text = "Thêm thành viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswd;
    }
}