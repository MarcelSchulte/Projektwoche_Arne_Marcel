using System;
using System.Net.Sockets;

namespace xxx
{
    public class ClientDisconnectedEventArgs : EventArgs
    {
        public TcpClient Client { get; set; }

        public ClientDisconnectedEventArgs(TcpClient client)
        {
            this.Client = client;
        }
    }
}
