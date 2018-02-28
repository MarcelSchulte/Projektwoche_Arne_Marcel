using System;
using System.Net.Sockets;

namespace Monitoring_Projektwoche_Arne_Marcel
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
