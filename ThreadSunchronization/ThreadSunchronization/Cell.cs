using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ThreadSunchronization
{
    internal class Cell
    {
        int data;
        bool readTurn = false;
        public Cell()
        {
            
        }
        public void Write(int d)
        {
            Monitor.Enter(this);
            if (readTurn == true)
                Monitor.Wait(this);
            Console.WriteLine("Attemting is Writing");
            data = d;
            Thread.Sleep(2500);
            Console.WriteLine("Done Writing");
            Console.WriteLine();
            Console.WriteLine();
            readTurn = true;
            Monitor.Pulse(this);
            Monitor.Exit(this);

        }
        public void Read()
        {
            Monitor.Enter(this);
            if (readTurn == false)
                Monitor.Wait(this);
            Console.WriteLine("Attempting is reading");
            Console.WriteLine(data);
            Thread.Sleep(300);
            Console.WriteLine("Done Reading");
            readTurn = false;
            Monitor.Pulse(this);
            Monitor.Exit(this);
           
        }
    }
}
