using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadSunchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell c = new Cell();
            Producer pd = new Producer(c, 10);
            Consumer cs = new Consumer(c, 10);
            var t1 = new Thread(pd.Produce);
            var t2 = new Thread(cs.Cosume);
            t2.Start();
            t1.Start();
            
        }
    }
}
