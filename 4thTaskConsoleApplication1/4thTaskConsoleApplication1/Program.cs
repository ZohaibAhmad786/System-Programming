using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTaskConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,10,1,25,30};
            Console.WriteLine("Array Sorted in Ascending");
            var result = arr.OrderBy(d => d);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array Sorted in Descending");
            var result1 = arr.OrderByDescending(d => d);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
