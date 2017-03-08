using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TestingTCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ServerIP = "192.168.0.128";
            int PortNO = 2001;
            Encoding utf8 = Encoding.UTF8;
            TcpClient client = new TcpClient(ServerIP, PortNO);
            NetworkStream Stream = client.GetStream();
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
