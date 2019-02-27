using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadSunchronization
{
    internal class Producer
    {
        public Cell c;
        public int limit;

        public Producer(Cell c, int v)
        {
            this.c = c;
            this.limit = v;
        }
        public void Produce()
        {
            for (int i = limit; i >=1; i--)
            {
                c.Write(i);
            }
        }
    }
}