using System;
using System.Net.Sockets;

namespace Monitoring_Projektwoche_Arne_Marcel
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public TcpClient Client { get; set; }

        public ClientConnectedEventArgs(TcpClient client)
        {
            this.Client = client;
        }
    }
}
