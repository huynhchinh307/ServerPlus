namespace TestUiDemo
{
    partial class UCDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_socketnet = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.lbl_socketnet);
            this.panel11.Controls.Add(this.btn_stop);
            this.panel11.Controls.Add(this.btn_start);
            this.panel11.Controls.Add(this.panel_log);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Location = new System.Drawing.Point(39, 61);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(766, 334);
            this.panel11.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(574, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đang hoạt động : 1/100";
            // 
            // lbl_socketnet
            // 
            this.lbl_socketnet.AutoSize = true;
            this.lbl_socketnet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_socketnet.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_socketnet.Location = new System.Drawing.Point(23, 32);
            this.lbl_socketnet.Name = "lbl_socketnet";
            this.lbl_socketnet.Size = new System.Drawing.Size(106, 16);
            this.lbl_socketnet.TabIndex = 6;
            this.lbl_socketnet.Text = "Địa chỉ server: ";
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.Crimson;
            this.btn_stop.Location = new System.Drawing.Point(101, 184);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(117, 51);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Dừng";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_start.Location = new System.Drawing.Point(101, 70);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(117, 51);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Khởi động";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel_log
            // 
            this.panel_log.Location = new System.Drawing.Point(326, 43);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(410, 260);
            this.panel_log.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Location = new System.Drawing.Point(326, 32);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(390, 5);
            this.panel12.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(495, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Lịch sử";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng điều khiển";
            // 
            // UCDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(841, 458);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_socketnet;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel panel_log;
    }
}
