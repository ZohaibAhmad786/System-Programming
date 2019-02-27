using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

using System.Threading;
namespace TCPClient
{
    class Program
    {
        public static bool flag = false;
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            IPAddress address = IPAddress.Parse("192.168.102.1");
            client.Connect(address,9988);
            NetworkStream ns = client.GetStream();
            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);
            writer.AutoFlush = true;
            while (true)
            {
                new Thread(()=> {
                    var serverMsg = reader.ReadLine();
                    Console.WriteLine($"Server Message : {serverMsg}");
                    if (serverMsg == "end")
                        flag = true;
                }).Start();
                Console.WriteLine("Your Message");
                var myMsg = Console.ReadLine();
                new Thread(()=> {
                    
                    writer.WriteLine(myMsg);
                    if (myMsg == "end")
                        flag = true;
                }).Start();
               
                if (flag == true)
                    break;
            }
        }
    }
}
