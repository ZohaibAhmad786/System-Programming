using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace MultipleTCPClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //Client WorkFlow
            TcpClient tcpclient = new TcpClient();
            IPAddress address = IPAddress.Parse("192.168.102.1");
            tcpclient.Connect(address, 9999);
            NetworkStream ns = tcpclient.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);
            writer.AutoFlush = true;

            Console.WriteLine();
            //string clientIPAddress = ((IPEndPoint)tcpclient.Client.LocalEndPoint).Address.ToString();
            //var port = ((IPEndPoint)tcpclient.Client.LocalEndPoint).Port;
            //Console.WriteLine(clientIPAddress+":"+port);
           
            while (true)
            {

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
                        break;
                    }
                    else
                    {
                        var rep = reader.ReadLine();
                        Console.WriteLine(rep);
                    }

                }
            }

        }
    }
}
