using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace TCPServerApplication
{
    class Program
    {
        public static bool flag = false;
        static void Main(string[] args)
        {
            //Port Rang 1-1204 don't use it
            //App must Port no + Ip of other App
            TcpListener tcplistener = new TcpListener(9988);
            tcplistener.Start();// just like sql connection opening
            Console.WriteLine("I Am Ready For Communication...");
            Console.WriteLine("Waiting For Remot Client.....");
            Socket socket = tcplistener.AcceptSocket();//Blocking Function//App wait untill another fucntion or App call
            Console.WriteLine("Connected.........");
            Console.WriteLine($"My Detail : { socket.LocalEndPoint}");//IP end point Class// IP+POrt no tells
            Console.WriteLine($"Remote Detail : { socket.RemoteEndPoint}");//IP end point Class// IP+POrt no tells

            NetworkStream ns = new NetworkStream(socket);//data send recieve
            StreamWriter streamwriter = new StreamWriter(ns);
            StreamReader streamreader = new StreamReader(ns);
            streamwriter.AutoFlush = true;
            while (true)
            {
                var remotemsg = streamreader.ReadLine();
                
                new Thread(() =>
                {
                    Console.WriteLine("Type Message...");
                var serverNsg = Console.ReadLine();
                    streamwriter.WriteLine(serverNsg);

                    if (serverNsg == "end")
                        flag = true;

                }).Start();
                new Thread(() =>
                {
                    
                    Console.WriteLine($"Client Message : {remotemsg}");
                    if (remotemsg == "end")
                        flag = true;
                }).Start();
                if (flag == true)
                {
                    break;
                }
            }
            tcplistener.Stop();
        }
    }
}
