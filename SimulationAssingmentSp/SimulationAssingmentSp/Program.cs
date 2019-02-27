using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SimulationAssingmentSp
{
    class Program
    {
        private static SameDataBank Db1, Db2, Db3;
        private static bool flag=false;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Search");
            int number = int.Parse(Console.ReadLine());
            Db1 = new SameDataBank(number);
            Db2 = new SameDataBank(number);
            Db3 = new SameDataBank(number);
            var signal = new AutoResetEvent[]
            {
                new AutoResetEvent(false),
                new AutoResetEvent(false),
                new AutoResetEvent(false)
            };
            Console.WriteLine();
            Console.WriteLine("Searching Data !!!! ");
            Thread t1 = new Thread(delegate () { flag = Db1.SeachData(signal[0]); });
            Thread t2 = new Thread(delegate () { flag = Db2.SeachData(signal[1]); });
            Thread t3 = new Thread(delegate () { flag = Db3.SeachData(signal[2]); });
           
            t1.Start();
            t2.Start();
            t3.Start();

            int index = WaitHandle.WaitAny(signal);
            if (flag == true)
            {
                if (index == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Data Found in the DATABANK1   ");
                }
                else if (index==1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Data Found in the DATABANK2 ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Data Found in the DATABANK3");
                }
            }else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry!!!  Data Not Found In DATABANK ");
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
