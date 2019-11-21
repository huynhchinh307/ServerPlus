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

namespace TestUiDemo
{
    public partial class User : UserControl
    {
        public Socket client;
        public string nickname;
        public User()
        {
            InitializeComponent();
        }
        public void AddUser(string username,  Socket skclient)
        {
            client = skclient;
            nickname = username;
            lbl_name.Text = nickname;
            try
            {
                lbl_ie.Text = client.RemoteEndPoint.ToString();
            }
            catch
            {
                lbl_ie.Text = "255.255.255.255";
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            UCMessger.Messger name = new UCMessger.Messger();
            name.setMessger(lbl_name.Text, client);
            if (!UCInbox.Instance.MessgerContainer.Controls.Equals(name))
            {
                name.Dock = DockStyle.Fill;
                UCInbox.Instance.MessgerContainer.Controls.Add(name);
            }
            UCInbox.Instance.MessgerContainer.Controls[UCInbox.Instance.MessgerContainer.Controls.IndexOf(name)].BringToFront();
        }
        public override bool Equals(Object obj)
        {
            var item = obj as User;

            if (item == null)
            {
                return false;
            }

            return this.nickname.Equals(item.nickname);
        }
       
    }
}
