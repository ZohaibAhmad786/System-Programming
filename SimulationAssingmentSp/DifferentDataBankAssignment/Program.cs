using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace DifferentDataBankAssignment
{
    class Program
    {
        private static DataBankFirst dbfirst;
        private static DataBankSecond dbsecond;
        private static DataBankThird dbthird;

        static void Main(string[] args)
        {

            var signal = new AutoResetEvent[]
            {
                new AutoResetEvent(false),new AutoResetEvent(false),new AutoResetEvent(false)
            };
            Console.WriteLine("Enter A Number to Search from DATABANKS ");
            int num = int.Parse(Console.ReadLine());
            dbfirst = new DataBankFirst(num);
            dbsecond = new DataBankSecond(num);
            dbthird = new DataBankThird(num);
            Thread t1 = new Thread(delegate ()
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                if (dbfirst.SearchData(signal[0]))
                {
                    Console.WriteLine($"Value “{num}”  found in DATABANK_FIRST {st.ElapsedMilliseconds}");
                }
                st.Stop();
            });
            Thread t2 = new Thread(delegate ()
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                if (dbsecond.SearchData(signal[1]))
                {

                    Console.WriteLine($"Value “{num}”  found in DATABANK_Second " + st.ElapsedMilliseconds);

                }
                st.Stop();
            });
            Thread t3 = new Thread(delegate ()
            {

                Stopwatch st = new Stopwatch();
                st.Start();
                if (dbthird.SearchData(signal[2]))
                {
                    Console.WriteLine($"Value “{num}”  found in DATABANK_THIRD " + st.ElapsedMilliseconds);
                }
                st.Stop();
            });
            t1.Start();
            t2.Start();
            t3.Start();
            WaitHandle.WaitAll(signal);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
