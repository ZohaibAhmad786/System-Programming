using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart t1 = new ThreadStart(print);
            Thread T1 = new Thread(t1);
            T1.Start();
            ThreadStart t2 = new ThreadStart(calculate);
            Thread T2 = new Thread(t2);
            T2.Start();
            Console.ReadKey();
        }
        public static void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public static void calculate()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = i + sum;
                Console.WriteLine(sum);
                Thread.Sleep(1000);
            }
        }
    }
}
