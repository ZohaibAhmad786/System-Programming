using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            client.Connect("127.0.0.1", 9988);
            while (true)
            {
                Console.WriteLine("your message");
                var msg = Console.ReadLine();
                byte[] dataone = Encoding.ASCII.GetBytes(msg);
                client.Send(dataone, dataone.Length);


                IPEndPoint ep = null;
                //Console.WriteLine(" waiting....");
                byte[] data = client.Receive(ref ep);
                var msgone = Encoding.ASCII.GetString(data);
                Console.WriteLine("{0}  {1} ", ep.ToString(), msgone);
            }
        }
    }
}
