using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadingAssignment
{
    class Program
    {
        public static List<int> st = new List<int>();

        
        static void Main(string[] args)
        {
            Thread ts1 = new Thread(Even);
            Thread ts2 = new Thread(ODD);
            ts1.Start();
            Thread.Sleep(1000);
            ts2.Start();
            Console.ReadKey();
            for (int i = 0; i < st.Count; i++)
            {
                Console.WriteLine(st[i].ToString());
            }
            Console.ReadKey();

        }
        static void Even()
        {
            for (int i = 0; i < 2; i++)
            {
                lock (st)
                {
                    for (int j = 0; j < 10; j += 2)
                    {
                        st.Add(j);
                    }
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done even...");
        }
        static void ODD()
        {
            for (int i = 0; i < 2; i++)
            {
                lock (st)
                {
                    for (int j = 1; j < 10; j += 2)
                    {
                        st.Add(j);
                    }
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done Odd...");
        }
        
    }
}
