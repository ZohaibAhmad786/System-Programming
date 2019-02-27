using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;

namespace ClientworkFlow
{
    class Program
    {
        public static TcpClient client = new TcpClient();
        public static IPAddress ipaddress = IPAddress.Parse("192.168.102.1");
        public static bool f = false;
        static void Main(string[] args)
        {
           
            client.Connect(ipaddress, 9987);
            NetworkStream ns = client.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);
            writer.AutoFlush = true;

            Console.WriteLine();
            //string clientIPAddress = ((IPEndPoint)tcpclient.Client.LocalEndPoint).Address.ToString();
            //var port = ((IPEndPoint)tcpclient.Client.LocalEndPoint).Port;
            //Console.WriteLine(clientIPAddress+":"+port);
            while (true)
            {
                new Thread(() => {

                    var serverRequestReply = reader.ReadLine();

                    if (serverRequestReply.Equals("Yes"))
                    {

                        Console.WriteLine();
                        Console.WriteLine("You Are Successfully Connected With Server");
                        Console.WriteLine();

                        Console.WriteLine("Enter arid no");
                        var an = Console.ReadLine();
                        writer.WriteLine(an);
                        if (an == "Exit" || an == "exit")
                        {
                             f = true;
                        }
                        else
                        {
                            var rep = reader.ReadLine();
                            Console.WriteLine(rep);
                        }

                    }
                }).Start();
                if (f == true)
                {
                    break;
                }
            }

        }


    }
}
