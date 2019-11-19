namespace TestUiDemo.UCMessger
{
    partial class Recived
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lbl_messger);
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 52);
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
            this.lbl_messger.TabIndex = 8;
            this.lbl_messger.Text = "Messger";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_date.Location = new System.Drawing.Point(149, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "date";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_name.Location = new System.Drawing.Point(-3, -1);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Siri ~_~";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_time.Location = new System.Drawing.Point(11, 15);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(75, 16);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Says Hello";
            // 
            // Recived
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_time);
            this.Name = "Recived";
            this.Size = new System.Drawing.Size(264, 84);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_messger;
    }
}
