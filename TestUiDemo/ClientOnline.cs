using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestUiDemo
{
    class ClientOnline
    {
        public string nickname;
        public Socket client;
        public ClientOnline(string name, Socket socket)
        {
            nickname = name;
            client = socket;
        }
        public override string ToString()
        {
            return nickname.ToString();
        }
    }
}
