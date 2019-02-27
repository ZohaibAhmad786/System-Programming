using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;
namespace ServerSendMessageToAllClientsTCP
{
    class Program
    {
        public static int ConnectionPool = 2;//decide how many client do you want to connect with server 
        public static Queue<Socket> soc = new Queue<Socket>();
        public static Socket socket;
        public static StreamReader reader;
        public static StreamWriter writer;
        public static StreamWriter sw;
        public static string contermination, con;
        public static bool flag = true;
        static void Main(string[] args)
        {
            //Server WorkFlow
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
            TcpListener listener = new TcpListener(9999);
            listener.Start();
            Console.WriteLine("I Am Ready For Communication...");
            Console.WriteLine(".............Waiting for Remote Client..........");
            while (ConnectionPool >= 0)
            {
                MaintainConnection(listener, stu);
            }
            listener.Stop();
        }
        public static void MaintainConnection(TcpListener listener, List<Student> stu)
        {
            #region Managing Request
            if (ConnectionPool > 0)
            {
                socket = listener.AcceptSocket();
                ConnectionPool--;
                new Thread(() =>
                {
                    con = ($"Client IP&PortNo. : {socket.RemoteEndPoint}, Connection Time : {DateTime.Now.ToLongTimeString()};");

                    Console.WriteLine("Connected.........");
                    Console.WriteLine($"My Detail : { socket.LocalEndPoint}");//IP end point Class// IP+POrt no tells
                    Console.WriteLine($"Remote Detail : { socket.RemoteEndPoint}");//IP end point Class// IP+POrt no tells
                    NetworkStream ns = new NetworkStream(socket);
                    writer = new StreamWriter(ns);
                    reader = new StreamReader(ns);
                    writer.AutoFlush = true;
                    while (true)
                    {

                        new Thread(() => {
                            var serverMsg = "Yes";
                            writer.WriteLine(serverMsg);
                            var clientMsg = reader.ReadLine();
                            if (clientMsg == "Exit" || clientMsg == "exit")
                            {
                                ConnectionPool++;

                                contermination = ($"Client IP&PortNo. : {socket.RemoteEndPoint}, Connection Terminate Time : {DateTime.Now.ToLongTimeString()};");
                                flag = false;
                                
                            }

                            var res = stu.FirstOrDefault(v => v.AridNo == clientMsg);
                            if (res == null)
                            {
                                writer.WriteLine("Data not exist");
                            }
                            else
                            {
                                writer.WriteLine(res);
                            }
                        }).Start();
                        if (flag == false)
                        {
                            break;

                        }
                        Console.WriteLine("You want to send your message to all clients");
                        string option = Console.ReadLine();

                        new Thread(()=> {
                            if (option == "yes")
                            {
                                writer.WriteLine("Connection terminated soon");
                            }
                        }).Start();
                    }
                }).Start();
            }
            #endregion
        }
    }
}
