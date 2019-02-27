using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Delegates_KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Print = delegate() { Console.WriteLine("Hello"); };
            Print.Invoke();
            Action<string> Print1 = delegate (string s){ Console.WriteLine(s); };
            Print1.Invoke("Hello how are you");

            Func<int, bool> isEven = delegate (int x) { return x % 2 == 0;  };
            //isEven.Invoke(5);
            Console.WriteLine( isEven.Invoke(5));
            Func<int, int, int> add = delegate (int x, int y) { return (x + y); };
            Console.WriteLine(add(15,80));
            Console.ReadKey();
        }
    }
}
