using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TestUiDemo
{
    public partial class UCInbox : UserControl
    {
        static UCInbox _obj;
        public UCInbox()
        {
            InitializeComponent();
        }
        public static UCInbox Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCInbox();
                }
                return _obj;
            }
        }
        private void UCInbox_Load(object sender, EventArgs e)
        {
            _obj = this;
        }
        public Panel MessgerContainer
        {
            get { return panelMess; }
            set { panelMess = value; }
        }
        public FlowLayoutPanel OnlineContainer
        {
            get { return panel_online; }
            set { panel_online = value; }
        }
    }
}
