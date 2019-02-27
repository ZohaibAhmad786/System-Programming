using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskTolist
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
            var res1 = arr1.Where(d => d > 0).ToList();
            arr1[2] = 5;
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            List<Book> books = new List<Book>();
            books.Add(new Book { Bname = "C++", AuthName = "Robert", Price = 250 });
            books.Add(new Book { Bname = "SP", AuthName = "Dietel", Price = 150 });
            books.Add(new Book { Bname = "OOP", AuthName = "James", Price = 350 });
            books.Add(new Book { Bname = "CA", AuthName = "Phill", Price = 550 });
            books.Add(new Book { Bname = "CC", AuthName = "Jimmy", Price = 200 });
            var result = books.Where(d => d.Price > 200);
            books[2].Price = 150;
            foreach (var item in result)
              
            {
                Console.WriteLine("{0} : {1} : {2} ",item.Bname,item.AuthName,item.Price);
            }
            Console.WriteLine("=====================================================");
            books[2].Price = 350;
            var result1 = books.Where(d => d.Price > 200).ToList(); ;
            books[2].Price = 150;
            foreach (var item in result1)

            {
                Console.WriteLine("{0} : {1} : {2} ", item.Bname, item.AuthName, item.Price);
            }
            Console.WriteLine("=====================================================");
            books[2].Price = 350;
            var result2 = books.Where(d => d.Price > 200);
            books[2].AuthName = "Robert";
            foreach (var item in result2)

            {
                Console.WriteLine("{0} : {1} : {2} ", item.Bname, item.AuthName, item.Price);
            }
            Console.WriteLine("=====================================================");
            books[2].AuthName = "James";
            var result3 = books.Where(d => d.Price > 200).ToList();
            books[2].AuthName = "Robert";
            foreach (var item in result3)

            {
                Console.WriteLine("{0} : {1} : {2} ", item.Bname, item.AuthName, item.Price);
            }
            Console.ReadKey();
        }
    }
}
