using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2ndClassTaskConsoleApplication1
{
    //Override the insert fucntion such that it will insert value one step befor the specified index. 
    class Program
    {
        static void Main(string[] args)
        {
            MyArraList al = new MyArraList();
            int ind, val;
            Console.WriteLine("Enter any 5 Number ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + "th Number");
                Console.WriteLine("Enter the index number");
                ind = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value number");
                val = int.Parse(Console.ReadLine());
                al.Insert(ind, val);

            }
            foreach (var item in al)
            {
                Console.WriteLine("Values are : "+item);
            }
            Console.ReadKey();
        }
    }

    class MyArraList : ArrayList
    {
        public override void Insert(int index, object value)
        {
            index--;
            if (index < 0)
                index = 0;
            else if (index > base.Count)
                index = base.Count;
            base.Insert(index, value);
        }
    }
    
   
}
