using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadRandonNumberAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            var ini = new Monitor();
            ini.GeneratingRandonNumebrs += DisplayNumbers;
            ini.readData();
        }

        public static void DisplayNumbers(int v)
        {
            Console.WriteLine("Generated Number : "+v);
        }
    }
    class Monitor
    {
        public delegate void warning(int v);
        public event warning GeneratingRandonNumebrs;
        public void readData()
        {
            var v = new Random();
            int data;
            while (true)
            {
                data = v.Next(1, 500);
                GeneratingRandonNumebrs(data);
                Thread.Sleep(1000);
            }
        }
    }
}
