using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace serverudp
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient server = new UdpClient(9988);
            while (true)
            {
                IPEndPoint ep = null;
                Console.WriteLine(" waiting....");
                byte[] data = server.Receive(ref ep);
                string msg = Encoding.ASCII.GetString(data);
                Console.WriteLine("{0}  {1} ",ep.ToString(),msg);

                var msgone = Console.ReadLine(); ;
                byte[] dataone = Encoding.ASCII.GetBytes(msgone);
                server.Send(dataone, dataone.Length, ep);
            }
        }
    }
}
