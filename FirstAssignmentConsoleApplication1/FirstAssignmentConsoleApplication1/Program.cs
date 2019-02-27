using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
// this program is basically take input any limited number and reverse it by using non-function of ArrayList.
namespace FirstAssignmentConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList al = new MyArrayList();
            Console.WriteLine("Enter any 5 Numbers ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter "+(i+1)+"st Number");
                al.Add(Console.ReadLine());
            }
            
            foreach (var item in al)
            {
                
                Console.WriteLine(item + "");
            }
            Console.ReadKey();
        }
    }
    class  MyArrayList : ArrayList
    {
        public override int Add(object value)
        {
            base.Insert(0,value);
            return 1; 
        }
    }
}
