using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Without Using Tolist");
            var res = arr.Where(d => d > 0);
            arr[2] = 5;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Using Tolist");
            int[] arr1 = { 1, 2, 3, 4, 5 };
            var res1 = arr1.Where(d => d > 0);
            arr1[2] = 5;
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
