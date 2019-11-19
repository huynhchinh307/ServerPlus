using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUiDemo
{
    public partial class UCLog : UserControl
    {
        public UCLog()
        {
            InitializeComponent();
        }
        public void SetUCLog(string text, string date, string code)
        {
            lbl_TextLog.Text = text;
            lbl_time.Text = date;
            switch (code)
            {
                case "start": //start server
                    {
                        this.BackColor = System.Drawing.Color.DodgerBlue;
                        break;
                    }
                case "stop": //stop server
                    {
                        BackColor = System.Drawing.Color.Firebrick;
                        break;
                    }
                case "join": //join socket
                    {
                        BackColor = System.Drawing.Color.ForestGreen;
                        break;
                    }
                case "logout": //logout socket
                    {
                        BackColor = System.Drawing.Color.OrangeRed;
                        break;
                    }
            }
        }
    }
}
