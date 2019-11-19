namespace TestUiDemo
{
    partial class UCLog
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
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_TextLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_time.Location = new System.Drawing.Point(3, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(74, 16);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "02-01-2019";
            // 
            // lbl_TextLog
            // 
            this.lbl_TextLog.AutoSize = true;
            this.lbl_TextLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextLog.ForeColor = System.Drawing.Color.Black;
            this.lbl_TextLog.Location = new System.Drawing.Point(3, 35);
            this.lbl_TextLog.Name = "lbl_TextLog";
            this.lbl_TextLog.Size = new System.Drawing.Size(57, 17);
            this.lbl_TextLog.TabIndex = 3;
            this.lbl_TextLog.Text = "Text log";
            // 
            // UCLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_TextLog);
            this.Name = "UCLog";
            this.Size = new System.Drawing.Size(286, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_TextLog;
    }
}
