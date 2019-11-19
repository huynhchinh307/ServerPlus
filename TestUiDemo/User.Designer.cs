namespace TestUiDemo
{
    partial class User
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
            this.lbl_ie = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ie
            // 
            this.lbl_ie.AutoSize = true;
            this.lbl_ie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ie.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ie.Location = new System.Drawing.Point(63, 24);
            this.lbl_ie.Name = "lbl_ie";
            this.lbl_ie.Size = new System.Drawing.Size(17, 17);
            this.lbl_ie.TabIndex = 5;
            this.lbl_ie.Text = "IE";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_name.Location = new System.Drawing.Point(59, 2);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 19);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "label1";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestUiDemo.Properties.Resources.avt_Image;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbl_ie);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User";
            this.Size = new System.Drawing.Size(239, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ie;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
