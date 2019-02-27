using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LockSlimFunctionThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new AutoResetEvent[] { new AutoResetEvent(false), new AutoResetEvent(false) };
            new Thread(delegate() { doWorkA(signal[0]); }).Start();
            new Thread(doWorkB).Start(signal[1]);
            Console.WriteLine("Wait For Both");
            WaitHandle.WaitAll(signal);
            Console.WriteLine("Done Waiting ");
            Console.ReadKey();

        }

        public static void doWorkA(object sender)
        {
            var signal = sender as AutoResetEvent;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing Work A  "+i);
                if (i == 5)
                {
                    signal.Set();
                    break;
                    
                }
                Thread.Sleep(1000);
            }
        }
        public static void doWorkB(object sender)
        {
            var signal = sender as AutoResetEvent;
            for (int i = 351; i < 360; i++)
            {
                Console.WriteLine("Doing Work B "+i);
                Thread.Sleep(750);
            }
            Console.WriteLine("Done B");
            signal.Set();
        }

    }

}
