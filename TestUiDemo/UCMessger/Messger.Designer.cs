namespace TestUiDemo.UCMessger
{
    partial class Messger
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
            this.txt_messger = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_messger
            // 
            this.txt_messger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_messger.ForeColor = System.Drawing.Color.Gray;
            this.txt_messger.Location = new System.Drawing.Point(6, 268);
            this.txt_messger.Name = "txt_messger";
            this.txt_messger.Size = new System.Drawing.Size(318, 13);
            this.txt_messger.TabIndex = 19;
            this.txt_messger.Text = "Says Hello :_:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(6, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 3);
            this.panel4.TabIndex = 20;
            // 
            // btn_send
            // 
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_send.Location = new System.Drawing.Point(342, 261);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(74, 27);
            this.btn_send.TabIndex = 18;
            this.btn_send.Text = "Gửi";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // panel_log
            // 
            this.panel_log.Location = new System.Drawing.Point(6, 34);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(410, 221);
            this.panel_log.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Location = new System.Drawing.Point(6, 23);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(390, 5);
            this.panel12.TabIndex = 15;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.ForeColor = System.Drawing.Color.Gray;
            this.lblMess.Location = new System.Drawing.Point(175, 4);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(71, 16);
            this.lblMess.TabIndex = 16;
            this.lblMess.Text = "Tin nhắn: ";
            // 
            // Messger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txt_messger);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lblMess);
            this.Name = "Messger";
            this.Size = new System.Drawing.Size(423, 293);
            this.Load += new System.EventHandler(this.Messger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_messger;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.FlowLayoutPanel panel_log;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblMess;
    }
}
