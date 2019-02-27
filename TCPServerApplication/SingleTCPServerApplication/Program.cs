using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace SingleTCPServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student { AridNo = "15-arid-2427", Name = "Zohaib Ahmad", Age = 24 });
            stu.Add(new Student { AridNo = "15-arid-3656", Name = "Ahmad Ali", Age = 23 });
            stu.Add(new Student { AridNo = "15-arid-9554", Name = "Ahmar Waqar", Age = 25 });
            stu.Add(new Student { AridNo = "15-arid-6565", Name = "Asad Khan", Age = 20 });
            stu.Add(new Student { AridNo = "15-arid-1122", Name = "Fahad Nazir", Age = 21 });
            stu.Add(new Student { AridNo = "15-arid-1325", Name = "Ameer Hamza", Age = 22 });
            stu.Add(new Student { AridNo = "15-arid-6587", Name = "Atif Manzoor", Age = 25 });
            stu.Add(new Student { AridNo = "15-arid-2358", Name = "Zubair Ahmad", Age = 26 });
            stu.Add(new Student { AridNo = "15-arid-9584", Name = "Muhammad Umair", Age = 27 });
            stu.Add(new Student { AridNo = "15-arid-2598", Name = "Amir Sohail", Age = 22 });
            stu.Add(new Student { AridNo = "15-arid-5455", Name = "Mustafa Bin Tahir", Age = 23 });
            stu.Add(new Student { AridNo = "15-arid-6885", Name = "Hamza Arshad", Age = 19 });
            TcpListener listener = new TcpListener(9898);
            listener.Start();
            while (true)
            {

                Console.WriteLine("I Am Ready For Communication...");
                Console.WriteLine(".............Waiting for Remote Client..........");
                Socket socket = listener.AcceptSocket();
                new Thread(() =>
                {
                    Console.WriteLine("Connected.........");
                    Console.WriteLine($"My Detail : { socket.LocalEndPoint}");//IP end point Class// IP+POrt no tells
                Console.WriteLine($"Remote Detail : { socket.RemoteEndPoint}");//IP end point Class// IP+POrt no tells
                NetworkStream ns = new NetworkStream(socket);
                    StreamWriter writer = new StreamWriter(ns);
                    StreamReader reader = new StreamReader(ns);
                    writer.AutoFlush = true;
                    while (true)
                    {
                    //Console.WriteLine("Server Typing Message");
                    //var serverMsg = Console.ReadLine();
                    //writer.WriteLine(serverMsg);
                    //if (serverMsg == "Exit" || serverMsg == "exit")
                    //    break;
                    var clientMsg = reader.ReadLine();
                        if (clientMsg == "Exit" || clientMsg == "exit")
                            break;
                    //Console.WriteLine($"Client Replied : {clientMsg}");
                    var res = stu.FirstOrDefault(v => v.AridNo == clientMsg);
                        if (res == null)
                        {
                            Console.WriteLine("Data not exist");
                        }
                        else
                        {
                            writer.WriteLine(res);
                        }


                    }
                }).Start();
            };
            listener.Stop();
        }
    }
}
