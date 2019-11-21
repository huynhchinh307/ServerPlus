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
using System.Threading;
using System.Data.SqlClient;
using System.IO;

namespace TestUiDemo
{
    internal partial class UCDashboard : UserControl
    {
        int online = 1;
        string[] messagerstring;
        List<ClientOnline> listOnline = new List<ClientOnline>(100);
        bool _isShutdown = false;
        private static Socket server, client;
        private static byte[] data = new byte[1024 * 5000];
        private int size = 1024 * 5000;
        static UCDashboard _obj;
        public UCDashboard()
        {
            InitializeComponent();
        }
        public static UCDashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCDashboard();
                }
                return _obj;
            }

        }
        public List<ClientOnline> ListOnline
        {
            get { return listOnline; }
            set { listOnline = value; }
        }
        private void UCDashboard_Load(object sender, EventArgs e)
        {
            panel_log.AutoScroll = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _isShutdown = false;
            //Tạo thông báo :))
            Form1.Instance.TaoThongBao.BalloonTipText= "Máy chủ đã khởi động....";
            Form1.Instance.TaoThongBao.Visible = true;
            Form1.Instance.TaoThongBao.ShowBalloonTip(10);
            //Ghi lịch sử
            UCLog uc = new UCLog();
            uc.SetUCLog("Máy chủ đã khởi động....", DateTime.Now.ToString(), "start");
            panel_log.Controls.Add(uc);
            panel_log.ScrollControlIntoView(uc);
            btn_stop.Enabled = true;
            btn_start.Enabled = false;
            //Mở sẵn UCInbox
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCInbox"))
            {
                UCInbox ucinbox = new UCInbox();
                Form1.Instance.PnlContainer.Controls.Add(ucinbox);
            }
            //Thêm Anonymus làm user online
            listOnline.Add(new ClientOnline("Public",client));
            User Anonymous = new User();
            Anonymous.AddUser("Public", server);
            if (!UCInbox.Instance.OnlineContainer.Controls.Contains(Anonymous))
            {
                UCInbox.Instance.OnlineContainer.Controls.Add(Anonymous);
            }
            //Tạo UI messager nhận chat toàn server
            UCMessger.Messger name = new UCMessger.Messger();
            name.setMessger("Public", client);
            if (!UCInbox.Instance.MessgerContainer.Controls.Equals(name))
            {
                name.Dock = DockStyle.Fill;
                UCInbox.Instance.MessgerContainer.Controls.Add(name);
            }
            
            //Cấu hình socket làm server
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                                   ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptConn), server);
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //Làm mới danh sách online
            listOnline = null;
            listOnline = new List<ClientOnline>();
            //Giải phóng client và server
            _isShutdown = true;
            if(client!= null)
                client.Close();
            server.Close();
            //Tạo thông báo :))
            Form1.Instance.TaoThongBao.BalloonTipText = "Máy chủ đã dừng....";
            Form1.Instance.TaoThongBao.Visible = true;
            Form1.Instance.TaoThongBao.ShowBalloonTip(10);
            //Ghi lịch sử
            UCLog uc = new UCLog();
            uc.SetUCLog("Máy chủ đã dừng....", DateTime.Now.ToString(), "stop");
            panel_log.Controls.Add(uc);
            panel_log.ScrollControlIntoView(uc);
            //Điều khiển bật tắt các nút
            btn_stop.Enabled = false;
            btn_start.Enabled = true;
        }
        void AcceptConn(IAsyncResult iar)
        {
            if (_isShutdown == false)
            {
                Socket oldserver = (Socket)iar.AsyncState;
                client = oldserver.EndAccept(iar);
                //Xữ lý đăng nhập
                int recv = client.Receive(data);
                string datalogin = Encoding.UTF8.GetString(data, 0, recv);
                string[] account = datalogin.Split(' ');
                {
                    //Kết nối csdl và truy vấn người dùng
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project-Chat\ServerChat\ServerChat\Client.mdf;Integrated Security=True;Connect Timeout=30");
                    string sql = "Select count(*) from Account where Username='" + account[0] + "' and Password='" + account[1] + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int i = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (i > 0)
                    {
                        client.Send(Encoding.UTF8.GetBytes("1"));
                        online = online + 1;
                        listOnline.Add(new ClientOnline(account[0], client));
                        //Tạo thông báo :))
                        Form1.Instance.TaoThongBao.BalloonTipText = "Đã kết nối: " + account[0];
                        Form1.Instance.TaoThongBao.Visible = true;
                        Form1.Instance.TaoThongBao.ShowBalloonTip(10);
                        //Ghi lịch sử
                        UCLog uc = new UCLog();
                        uc.SetUCLog("Đã kết nối: " + account[0], DateTime.Now.ToString(), "join");
                        panel_log.Invoke(new Action(() => panel_log.Controls.Add(uc)));
                        panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(uc)));
                        //Thêm user vào UI User online
                        User user = new User();
                        user.AddUser(account[0], client);
                        UCInbox.Instance.Invoke(new Action(() => UCInbox.Instance.OnlineContainer.Controls.Add(user)));
                        //Tạo khung chat
                        UCMessger.Messger name = new UCMessger.Messger();
                        name.setMessger(account[0], client);
                        if (!UCInbox.Instance.MessgerContainer.Controls.Equals(name))
                        {
                            UCInbox.Instance.Invoke(new Action(() => UCInbox.Instance.MessgerContainer.Controls.Add(name)));
                        }
                        //Gửi thông báo tới tin nhắn Anonymous
                        foreach (UCMessger.Messger c in UCInbox.Instance.MessgerContainer.Controls)
                            if (c.getnickname().Equals("Public"))
                            {
                                c.SetRecivide("Thông báo", "Đã kết nối: " + account[0]);

                            }
                        //Gửi danh sách tới các client
                        for(int j=1; j<listOnline.Count; j++)
                        {
                            for(int k=1; k< listOnline.Count; k++)
                            if (!listOnline[j].nickname.Equals(listOnline[k].nickname))
                                    listOnline[j].client.Send(Encoding.UTF8.GetBytes("OnlinePacket:" + listOnline[k].nickname));
                        }
                        
                        //Cho phép nhận packet từ client
                        client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), client);
                        //Chờ kết nối tiếp theo
                        server.BeginAccept(new AsyncCallback(AcceptConn), server);
                    }
                    else
                    {
                        //Send key 0 báo login fail, tiếp tục mở chờ đăng nhập tiếp theo
                        client.Send(Encoding.UTF8.GetBytes("0"));
                        client.Close();
                        server.BeginAccept(new AsyncCallback(AcceptConn), server);
                    }

                }
            }
            else return;
            
        }
        void ReceiveData(IAsyncResult iar)
        {
            if (_isShutdown == false)
            {
                Socket remote = (Socket)iar.AsyncState;
                int recv = remote.EndReceive(iar);
                string stringData = Encoding.UTF8.GetString(data, 0, recv);
                /*Messager string
                 * 0: Loại messger
                 * 1: Tên người gửi
                 * 2: Người nhận
                 * 3: Nội dung
                 */

                messagerstring = stringData.Split(':');
                try
                {
                    if (messagerstring[3] == "/exit")
                    {
                        //Xóa khỏi list online
                        listOnline.Remove(new ClientOnline(messagerstring[1], remote));
                        //Xóa khỏi UI UserOnline
                        User user = new User();
                        user.AddUser(messagerstring[1], client);
                        foreach (User c in UCInbox.Instance.OnlineContainer.Controls)
                            if (c.Equals(user))
                                UCInbox.Instance.Invoke(new Action(() => UCInbox.Instance.OnlineContainer.Controls.Remove(c)));
                        //Tạo lịch sử phía UI Chat Public
                        foreach (UCMessger.Messger c in UCInbox.Instance.MessgerContainer.Controls)
                            if (c.getnickname().Equals("Public"))
                            {
                                c.SetRecivide("Thông báo", "Mất kết nối tới : " + messagerstring[1]);
                            }
                        //Tạo lịch sử
                        UCLog uc = new UCLog();
                        uc.SetUCLog(messagerstring[1] + " đã đăng xuất", DateTime.Now.ToString(), "logout");
                        remote.Close();
                        panel_log.Invoke(new Action(() => panel_log.Controls.Add(uc)));
                        panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(uc)));
                        //Gửi danh sách online lại bên các client
                        for (int j = 1; j < listOnline.Count; j++)
                        {
                            for (int k = 1; k < listOnline.Count; k++)
                                if (!listOnline[j].nickname.Equals(listOnline[k].nickname))
                                    listOnline[j].client.Send(Encoding.UTF8.GetBytes("OnlinePacket:" + listOnline[k].nickname));
                        }
                        //Tạo thông báo :))
                        Form1.Instance.TaoThongBao.BalloonTipText = messagerstring[1] + " đã đăng xuất";
                        Form1.Instance.TaoThongBao.Visible = true;
                        Form1.Instance.TaoThongBao.ShowBalloonTip(5);
                    }
                    else
                    {
                        string messagerfull = stringData.Substring(messagerstring[1].Length + 1 + messagerstring[2].Length + 1 + 2);
                        byte[] message = Encoding.UTF8.GetBytes("m:"+messagerstring[1]+":Public:"+ messagerfull);
                        //Xữ lý gửi tin nhắn đến public
                        if (messagerstring[2].Equals("Public"))
                        {
                            for (int i = 1; i < listOnline.Count; i++)
                            {
                                if (!listOnline[i].nickname.Equals(messagerstring[1]))
                                    listOnline[i].client.BeginSend(message, 0, message.Length, SocketFlags.None, new
                               AsyncCallback(SendData), listOnline[i].client);

                            }
                            foreach (UCMessger.Messger c in UCInbox.Instance.MessgerContainer.Controls)
                                if (c.getnickname().Equals(messagerstring[2]))
                                {
                                    c.SetRecivide(messagerstring[1], messagerfull);
                                    break;
                                }
                            Form1.Instance.TaoThongBao.BalloonTipText = "Có tin nhắn mới đến Public";
                            Form1.Instance.TaoThongBao.Visible = true;
                            Form1.Instance.TaoThongBao.ShowBalloonTip(5);
                        }
                        //Xữ lý gửi tin nhắn đến server
                        if (messagerstring[2].Equals("Server"))
                        {
                            foreach (UCMessger.Messger c in UCInbox.Instance.MessgerContainer.Controls)
                                if (c.getnickname().Equals(messagerstring[1]))
                                {
                                    c.SetRecivide(messagerstring[1], messagerfull);
                                }
                            Form1.Instance.TaoThongBao.BalloonTipText = "Có tin nhắn từ " + messagerstring[1];
                            Form1.Instance.TaoThongBao.Visible = true;
                            Form1.Instance.TaoThongBao.ShowBalloonTip(5);
                        }
                        else
                        //Xữ lý tin nhắn client gửi client
                        {
                            for (int i = 1; i < listOnline.Count; i++)
                                if (listOnline[i].nickname.Equals(messagerstring[2]))
                                {
                                    //Chuyển toàn bộ messenger tới người nhận đích
                                    listOnline[i].client.BeginSend(data, 0, data.Length, SocketFlags.None, new
                                           AsyncCallback(SendData), listOnline[i].client);
                                    break;
                                }
                        }
                        
                    }
                    remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
                }
                catch { }
            }
            else return;
            
        }
        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }
    }
}
