namespace TestUiDemo.UCMessger
{
    partial class Sent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_messger = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_messger);
            this.panel1.Location = new System.Drawing.Point(108, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 52);
            this.panel1.TabIndex = 0;
            // 
            // lbl_messger
            // 
            this.lbl_messger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_messger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messger.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_messger.Location = new System.Drawing.Point(3, 13);
            this.lbl_messger.Name = "lbl_messger";
            this.lbl_messger.Size = new System.Drawing.Size(256, 39);
            this.lbl_messger.TabIndex = 9;
            this.lbl_messger.Text = "Messger";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_date.Location = new System.Drawing.Point(105, 58);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(112, 13);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "2019/08/11 11:11:11 AM";
            // 
            // Sent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panel1);
            this.Name = "Sent";
            this.Size = new System.Drawing.Size(376, 71);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_messger;
    }
}
