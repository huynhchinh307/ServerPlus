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

namespace TestUiDemo.UCMessger
{
    public partial class Messger : UserControl
    {
        Socket client;
        string nickname;
        static Messger _obj;
        public Messger()
        {
            InitializeComponent();
        }
        public static Messger Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Messger();
                }
                return _obj;
            }
        }

        public FlowLayoutPanel MessContainer
        {
            get { return panel_log; }
            set { panel_log = value; }
        }
        public void setMessger(string name, Socket client)
        {
            nickname = name;
            lblMess.Text += nickname;
            this.client = client;
        }
        private void Messger_Load(object sender, EventArgs e)
        {
            panel_log.AutoScroll = true;
        }
        public string getnickname()
        {
            return nickname;
        }
        public Socket getclient()
        {
            return client;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if(nickname.Equals("Public"))
            {
                Sent sent = new Sent();
                sent.SetSent(txt_messger.Text);
                panel_log.Controls.Add(sent);
                panel_log.ScrollControlIntoView(sent);
                byte[] message = Encoding.UTF8.GetBytes("m:Server:Public:"+txt_messger.Text);
                txt_messger.Clear();
                for(int i=1;i<UCInbox.Instance.OnlineContainer.Controls.Count; i++)
                {
                    User user = (User)UCInbox.Instance.OnlineContainer.Controls[i];
                    user.client.BeginSend(message, 0, message.Length, SocketFlags.None, new
                               AsyncCallback(SendData), user.client);
                }
            }
            else
            {
                Sent sent = new Sent();
                sent.SetSent(txt_messger.Text);
                panel_log.Controls.Add(sent);
                panel_log.ScrollControlIntoView(sent);
                byte[] message = Encoding.UTF8.GetBytes("m:Server:"+nickname+":"+txt_messger.Text);
                txt_messger.Clear();
                client.BeginSend(message, 0, message.Length, SocketFlags.None, new
                               AsyncCallback(SendData), client);
            }
            
        }
        public void SetRecivide(string name,string mess)
        {
            Recived recived = new Recived();
            recived.SetRecived(name,mess);
            panel_log.Invoke(new Action(() => panel_log.Controls.Add(recived)));
            panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(recived)));
        }
        void SendData(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            int sent = client.EndSend(iar);
        }
        public override bool Equals(Object obj)
        {
                Messger p = (Messger)obj;
                return (nickname.Equals(p.nickname));
        }
        
    }
}
