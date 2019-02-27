using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TakeSkipMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {1,2,3,4,5,6 };
            var res = data.Skip(3);//No. of values to skip from array
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            var res1 = data.Take(3);
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
