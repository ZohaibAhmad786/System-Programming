using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace WithoutUsingLockSlimMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray aa = new MyArray();
            var a = new MyArray();
            new Thread(a.Print).Start("Mr.A");
            new Thread(a.Add).Start("Mr.B");
            new Thread(a.Print).Start("Mr.A");
            new Thread(a.Search).Start("Mr.C");
            new Thread(a.delete).Start("Mr.D");
            new Thread(a.Add).Start("Mr.E");
            new Thread(a.Print).Start("Mr.A");
            new Thread(a.update).Start("Mr.F");
            Console.ReadKey();

        }
    }
    class MyArray
    {
        List<int> data = new List<int> { 5, 4, 8, 6, 9, 2 };
        ReaderWriterLock obj = new ReaderWriterLock();
        
        public MyArray()
        {
            
            
        }
        public void Add(object sender)
        {

            var name = sender as string;
            var r = new Random();
            Console.WriteLine();
            this.obj.AcquireWriterLock(Timeout.Infinite);
            Console.WriteLine("  ");
            Console.WriteLine("" + obj.WriterSeqNum + "");
            Console.WriteLine("{0} : Attempting to Add ", name);
            if (obj.IsWriterLockHeld)
            {
                data.Add(r.Next(4, 100));

                Thread.Sleep(new TimeSpan(0, 0, r.Next(1, 10)));
                

                Console.WriteLine("{0} : Done Adding ", name);
                obj.ReleaseWriterLock();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Print(object sender)
        {
            var name = sender as string;
            this.obj.AcquireReaderLock(Timeout.Infinite);
            if (obj.IsReaderLockHeld)
            {
                foreach (var item in data)
                {
                    Console.WriteLine("{0} : Printing ", name, item);
                    Thread.Sleep(500);
                }
                Console.WriteLine("{0} : Done Printing ", name);
                Console.WriteLine();
                Console.WriteLine();
                obj.ReleaseReaderLock();
            }
            
        }
        public void Search(object sender)
        {
            var name = sender as string;
            var r = new Random();
            this.obj.AcquireReaderLock(Timeout.Infinite);
            if (obj.IsReaderLockHeld)
            {
                var temp = r.Next(10, 90);
                foreach (var item in data)
                {
                    Console.WriteLine("{0} : Searching ", name);
                    if (item == temp)
                    {
                        Console.WriteLine("{0} : found Number ", name);
                    }
                }
                Thread.Sleep(400);
                Console.WriteLine("{0} : Done Searching ", name);
                Console.WriteLine();
                Console.WriteLine();
                obj.ReleaseReaderLock();
            }
            
        }
        public void delete(object sender)
        {
            var name = sender as string;
            var r = new Random();
            var temp = 5;
            this.obj.AcquireWriterLock(Timeout.Infinite);
            if (obj.IsWriterLockHeld)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine("{0} : Search for Delete ", name);
                    if (data[i] == temp)
                    {
                        data.Remove(data[i]);
                        Console.WriteLine("{0} : delete Number ", name);
                        foreach (var item in data)
                        {
                            Console.Write(" " + item);

                        }
                        Console.WriteLine();
                    }
                }
                Thread.Sleep(400);
                Console.WriteLine("{0} : Done Delete ", name);
                Console.WriteLine();
                obj.ReleaseWriterLock();
            }
            
        }
        public void update(object sender)
        {
            var name = sender as string;
            var r = new Random();
            var temp = 9;
            this.obj.AcquireWriterLock(Timeout.Infinite);
            if (obj.IsWriterLockHeld)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] == temp)
                    {
                        int index = data.FindIndex(a => a == data[i]);
                        data[index] = r.Next(1, 99);
                        Console.WriteLine("{0} : Update Number {1} {2} ", name, temp, data[index]);
                        foreach (var item in data)
                        {
                            Console.Write(" " + item);
                        }
                    }
                }
                Console.WriteLine();
                Thread.Sleep(400);
                Console.WriteLine("{0} : Done Update ", name);
                obj.ReleaseWriterLock();
            }
        }
    }
}
