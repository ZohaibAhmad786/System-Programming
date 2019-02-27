using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication2
{
    class Program
    {
        static ManualResetEvent mr = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            new Thread(check1).Start();
            new Thread(cont).Start();
          
            Console.ReadKey();
        }
        public  static void check1()
        {

            for (int i = 0; i < 10; i++)
            {
                mr.WaitOne();
                Console.WriteLine("loop1 " + i);

                Thread.Sleep(1000);
                if (i == 5)
                {
                    
                    
                   
                    Console.WriteLine("waiting");

                    //}else if (i==6)
                    //{
                    //    mr.WaitOne();
                    //}
                }
                mr.Reset();


            }
           // mr.WaitOne();
            
        }
        public static void cont()
        {
           
            mr.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("loop2 "+i);
                mr.Reset();
                Thread.Sleep(500);
                
            }
            
        }
    }
}
