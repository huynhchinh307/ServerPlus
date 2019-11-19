using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestUiDemo.UCMessger
{
    public partial class Sent : UserControl
    {
        public Sent()
        {
            InitializeComponent();
        }
        public void SetSent(string messger)
        {
            if (messger.Length > 60)
            {
                lbl_messger.Location = new Point(3, 0);
                lbl_messger.Size = new Size(256, 52);
            }
            else
            {
                lbl_messger.Location = new Point(3, 13);
                lbl_messger.Size = new Size(256, 39);
            }
            lbl_messger.Text = messger;
            lbl_date.Text = DateTime.Now.ToString();

        }
    }
}
