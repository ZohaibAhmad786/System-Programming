using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace Assignments_SP_1_Connection_Pool
{
    class Program
    {
        public static int ConnectionPool = 2, x=0;//decide how many client do you want to connect with server 
        public static List<Socket> soc = new List<Socket>();
        public static Socket socket;
        public static StreamReader reader;
        public static StreamWriter writer;
        public static StreamWriter sw;
        public static string contermination, con;
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
            while (true)
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
                    
                    Thread.CurrentThread.Name = "" + (x++);
                    con=($"Client IP&PortNo. : {socket.RemoteEndPoint}, Connection Time : {DateTime.Now.ToLongTimeString()};");

                    Console.WriteLine("Connected.........");
                    Console.WriteLine($"My Detail : { socket.LocalEndPoint}");//IP end point Class// IP+POrt no tells
                    Console.WriteLine($"Remote Detail : { socket.RemoteEndPoint}");//IP end point Class// IP+POrt no tells
                    NetworkStream ns = new NetworkStream(socket);
                    writer = new StreamWriter(ns);
                    reader = new StreamReader(ns);
                    writer.AutoFlush = true;
                    while (true)
                    {

                        
                        var serverMsg = "Yes";
                        writer.WriteLine(serverMsg);
                        var clientMsg = reader.ReadLine();
                        if (clientMsg == "Exit" || clientMsg == "exit")
                        {
                            ConnectionPool++;
                           
                            contermination=($"Client IP&PortNo. : {socket.RemoteEndPoint}, Connection Terminate Time : {DateTime.Now.ToLongTimeString()};");
                           
                            break;
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
                    }
                    FileStream fs = new FileStream(@"F:\\Study Material\\BSCS-7C\\System Programming\\Assignments SP 1 Connection Pool\\LogConnection.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(con + "::" + contermination);
                    sw.Close();

                }).Start();
            }
            #endregion
        }
    }
}
