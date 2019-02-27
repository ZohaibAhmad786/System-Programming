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
            TcpClient tcpclient = new TcpClient();
            IPAddress address = IPAddress.Parse("192.168.102.1");
            tcpclient.Connect(address, 9898);
            NetworkStream ns = tcpclient.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);
            writer.AutoFlush = true;

            while (true)
            {
                Console.WriteLine("Enter arid no");
                var an = Console.ReadLine();
                writer.WriteLine(an);
                if (an == "Exit" || an == "exit")
                    break;
                else
                {
                    var rep = reader.ReadLine();
                    Console.WriteLine(rep.ToString());
                }
                //var serverMsg = reader.ReadLine();
                //Console.WriteLine($"Server Msg : {serverMsg}");
                //if (serverMsg == "Exit" || serverMsg=="exit")
                //    break;
                //Console.WriteLine("Client is Typing  ");
                //var clientMsg = Console.ReadLine();
                //writer.WriteLine(clientMsg);
                //if (clientMsg == "Exit" || clientMsg == "exit")
                //    break;
            }
            //Console.ReadKey();
        }
    }
}
