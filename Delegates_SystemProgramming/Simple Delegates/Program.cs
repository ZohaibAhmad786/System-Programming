using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action Delegates which Have No return Type");
            Console.WriteLine("         1           ");
            Action print1 = print;
            print1.Invoke();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         2           ");
            Action<string> print2 = print;
            print2.Invoke("Hello");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         3           ");
            Action<int> Squ = Square;
            Squ.Invoke(3);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Func Delegates which Have any return Type not Void");
            Console.WriteLine("         4           ");
            Func<int,int,int> addition= Add;
            
            Console.WriteLine(addition.Invoke(3, 5));
            Console.WriteLine();
            Console.WriteLine("         5           ");
            Func<int,bool> Even = isEven;
            
            Console.WriteLine(Even.Invoke(5));
            
            Console.ReadKey();
        }
        public static void print()
        {
            Console.WriteLine("Hello No Argument");
        }
        public static void print(string s)
        {
            Console.WriteLine("Take 1 argument that is "+ s);
        }
        public static void Square(int x)
        {
            Console.WriteLine("Square = "+(x*x));
        }
        public static int Add(int x,int y)
        {
            return (x + y);
        }
        public static bool isEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
