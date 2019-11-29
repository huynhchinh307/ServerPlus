using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUiDemo
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        //Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //End move form
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public NotifyIcon TaoThongBao
        {
            get { return thongbao; }
            set { thongbao = value; }
        }
        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            _obj = this;
            UCDashboard uc = new UCDashboard();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCDashboard"].BringToFront();
            btnBack.Visible = false;
            select();
            p_dashboard.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_inbox_Click(object sender, EventArgs e)
        {
            select();
            p_inbox.Visible = true;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCInbox"))
            {
                UCInbox uc = new UCInbox();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc);
            }
            Form1.Instance.PnlContainer.Controls["UCInbox"].BringToFront();
            Form1.Instance.BackButton.Visible = true;

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            select();
            p_user.Visible = true;
            /*
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            {
                UCNext un = new UCNext();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCNext"].BringToFront();
            Form1.Instance.BackButton.Visible = true;
            */
        }
        public void select()
        {
            p_dashboard.Visible = false;
            p_adduser.Visible = false;
            p_user.Visible = false;
            p_setting.Visible = false;
            p_inbox.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            select();
            p_dashboard.Visible = true;
            Form1.Instance.PnlContainer.Controls["UCDashboard"].BringToFront();
            Form1.Instance.BackButton.Visible = false;
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            ThemThanhVien f = new ThemThanhVien();
            f.ShowDialog();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            select();
            p_setting.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
