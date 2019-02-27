using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action print = () => { Console.WriteLine("Hello"); };
            print.Invoke();
            Action<int> print1 = (x) => { Console.WriteLine(x * x); };
            print1.Invoke(5);
            Func<int, bool> isEven = (x) => { return x % 2 == 0; };
            Console.WriteLine(isEven.Invoke(10));
            Console.ReadKey();
        }
    }
}
