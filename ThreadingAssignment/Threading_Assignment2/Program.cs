using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Threading_Assignment2
{
    class Program
    {
        public static Thread t1, t2;
        static string whotoprint = "one";
        static void Main(string[] args)
        {
            var ts1 = new ThreadStart(doWork1);
            var ts2 = new ThreadStart(doWork2);
            t1 = new Thread(ts1);
             t2 = new Thread(ts2);
            t1.Start();
            t1.Name = "thread1";
            t2.Start();
            t2.Name = "thread2";
            Console.ReadKey();
          
        }
        public static void doWork1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" "+ i);
                Thread.Sleep(1000);
                if (i == 5)
                {
                    whotoprint = "two";
                    while(whotoprint=="two")
                    {
                        //waiting
                    }
                    
                }
              
            }
        }
        public static void doWork2()
        {
            while(whotoprint=="one")
            {
                //waiting
            }
            for (int i = 501; i <= 510; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " "+i);
                Thread.Sleep(1000);
            }
            whotoprint = "one";
        }

    }
}
