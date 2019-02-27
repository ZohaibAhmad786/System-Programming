using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _6thClassTaskLINQQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass[] data = { new MyClass { Name = "Biscuit", price = 10 },
                new MyClass { Name = "Choclate", price = 101 },
                new MyClass { Name = "Cake", price = 10000 },
                new MyClass { Name = "Ice Cream", price = 1 } };

            var res = data.OrderBy(d => d.price);
            foreach (var item in res)
            {
                Console.WriteLine("Name : " + item.Name+" Price : "+item.price);
            }
            Console.ReadKey();

            Console.WriteLine("Order By Ascending");
            double[] arr = {1.0,2.0,2.02,3.08,4.0,3.98,3.52,2.56,2.84,4.0,4.0,3.52,1.5,1.5,0.5};
            var res1 = arr.OrderBy(d => d);
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            Console.WriteLine("Order By Descending");
            var res2 = arr.OrderByDescending(d => d);
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            
            Console.WriteLine("Like %2");
            var res3 = data.Where(d => d.Name.EndsWith("e"));
            foreach (var item in res3)
            {
                Console.WriteLine("End Name with E Data : "+item.Name);
            }
            Console.ReadKey();

            Console.WriteLine("Aggregate Fucntion");
            var res4 = arr.Max();
            
                Console.WriteLine(res4);
            
            Console.ReadKey();

            Console.WriteLine("Aggregate Fucntion find Second Max Number");
            var mx1 = arr.Max();
            var mx2 = arr.Where(d => d < mx1).Max();
            Console.WriteLine(mx2);

            Console.ReadKey();
        }
    }
    class MyClass
    {
        public string Name
        {
            get; set;

        }
        public double price
        {
            get;
            set;
        }
    }
}
