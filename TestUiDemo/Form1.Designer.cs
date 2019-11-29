namespace TestUiDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_user = new System.Windows.Forms.Panel();
            this.p_adduser = new System.Windows.Forms.Panel();
            this.p_inbox = new System.Windows.Forms.Panel();
            this.p_setting = new System.Windows.Forms.Panel();
            this.p_dashboard = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_inbox = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.thongbao = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.p_user);
            this.panel1.Controls.Add(this.p_adduser);
            this.panel1.Controls.Add(this.p_inbox);
            this.panel1.Controls.Add(this.p_setting);
            this.panel1.Controls.Add(this.p_dashboard);
            this.panel1.Controls.Add(this.btn_Setting);
            this.panel1.Controls.Add(this.btn_inbox);
            this.panel1.Controls.Add(this.btn_adduser);
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pic_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 510);
            this.panel1.TabIndex = 0;
            // 
            // p_user
            // 
            this.p_user.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_user.Location = new System.Drawing.Point(0, 134);
            this.p_user.Name = "p_user";
            this.p_user.Size = new System.Drawing.Size(5, 33);
            this.p_user.TabIndex = 6;
            this.p_user.Visible = false;
            // 
            // p_adduser
            // 
            this.p_adduser.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_adduser.Location = new System.Drawing.Point(0, 173);
            this.p_adduser.Name = "p_adduser";
            this.p_adduser.Size = new System.Drawing.Size(5, 33);
            this.p_adduser.TabIndex = 5;
            this.p_adduser.Visible = false;
            // 
            // p_inbox
            // 
            this.p_inbox.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_inbox.Location = new System.Drawing.Point(0, 212);
            this.p_inbox.Name = "p_inbox";
            this.p_inbox.Size = new System.Drawing.Size(5, 33);
            this.p_inbox.TabIndex = 4;
            this.p_inbox.Visible = false;
            // 
            // p_setting
            // 
            this.p_setting.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_setting.Location = new System.Drawing.Point(0, 251);
            this.p_setting.Name = "p_setting";
            this.p_setting.Size = new System.Drawing.Size(5, 33);
            this.p_setting.TabIndex = 3;
            this.p_setting.Visible = false;
            // 
            // p_dashboard
            // 
            this.p_dashboard.BackColor = System.Drawing.Color.DodgerBlue;
            this.p_dashboard.Location = new System.Drawing.Point(0, 96);
            this.p_dashboard.Name = "p_dashboard";
            this.p_dashboard.Size = new System.Drawing.Size(5, 33);
            this.p_dashboard.TabIndex = 2;
            // 
            // btn_Setting
            // 
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.Location = new System.Drawing.Point(7, 251);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(38, 33);
            this.btn_Setting.TabIndex = 2;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_inbox
            // 
            this.btn_inbox.FlatAppearance.BorderSize = 0;
            this.btn_inbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inbox.Image = ((System.Drawing.Image)(resources.GetObject("btn_inbox.Image")));
            this.btn_inbox.Location = new System.Drawing.Point(8, 212);
            this.btn_inbox.Name = "btn_inbox";
            this.btn_inbox.Size = new System.Drawing.Size(38, 33);
            this.btn_inbox.TabIndex = 2;
            this.btn_inbox.UseVisualStyleBackColor = true;
            this.btn_inbox.Click += new System.EventHandler(this.btn_inbox_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.FlatAppearance.BorderSize = 0;
            this.btn_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adduser.Image = ((System.Drawing.Image)(resources.GetObject("btn_adduser.Image")));
            this.btn_adduser.Location = new System.Drawing.Point(8, 173);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(38, 33);
            this.btn_adduser.TabIndex = 2;
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_user
            // 
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_user.Image")));
            this.btn_user.Location = new System.Drawing.Point(8, 134);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(38, 33);
            this.btn_user.TabIndex = 2;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(8, 96);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(38, 33);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(4, 6);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(41, 42);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(49, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 52);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(788, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Hệ Thống";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(4, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.Location = new System.Drawing.Point(699, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(74, 27);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(590, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 27);
            this.button11.TabIndex = 2;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(550, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 27);
            this.button10.TabIndex = 2;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(510, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 27);
            this.button9.TabIndex = 2;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(470, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 27);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(49, 52);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(841, 458);
            this.panelContainer.TabIndex = 2;
            // 
            // thongbao
            // 
            this.thongbao.Icon = ((System.Drawing.Icon)(resources.GetObject("thongbao.Icon")));
            this.thongbao.Text = "Thông Báo";
            this.thongbao.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_dashboard;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_inbox;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel p_setting;
        private System.Windows.Forms.Panel p_user;
        private System.Windows.Forms.Panel p_adduser;
        private System.Windows.Forms.Panel p_inbox;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.NotifyIcon thongbao;
    }
}

