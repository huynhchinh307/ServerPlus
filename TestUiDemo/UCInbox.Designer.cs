namespace TestUiDemo
{
    partial class UCInbox
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
            this.panelMess = new System.Windows.Forms.Panel();
            this.panel_online = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.panelMess);
            this.panel11.Controls.Add(this.panel_online);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(39, 84);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(766, 334);
            this.panel11.TabIndex = 7;
            // 
            // panelMess
            // 
            this.panelMess.Location = new System.Drawing.Point(325, 13);
            this.panelMess.Name = "panelMess";
            this.panelMess.Size = new System.Drawing.Size(423, 293);
            this.panelMess.TabIndex = 11;
            // 
            // panel_online
            // 
            this.panel_online.Location = new System.Drawing.Point(0, 43);
            this.panel_online.Name = "panel_online";
            this.panel_online.Size = new System.Drawing.Size(280, 260);
            this.panel_online.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 5);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Người đang online";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhắn tin tới thành viên tham gia";
            // 
            // UCInbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label1);
            this.Name = "UCInbox";
            this.Size = new System.Drawing.Size(841, 458);
            this.Load += new System.EventHandler(this.UCInbox_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panel_online;
        private System.Windows.Forms.Panel panelMess;
    }
}
