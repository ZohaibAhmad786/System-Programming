using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ThreadSunchronization
{
    internal class Consumer
    {
        public Cell c;
        public int limite;

        public Consumer(Cell c, int v)
        {
            this.c = c;
            this.limite = v;
        }
        public void Cosume()
        {
            for (int i = 0 ; i < limite; i++)
            {
                c.Read();
            }
        }
    }
}