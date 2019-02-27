using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GroupByAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string AName=string.Empty, BName = string.Empty;
            int Price = 0;int bYear = 0;
            Book[] book = new Book[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter The Book Name : ");
                BName = Console.ReadLine() ;
                Console.WriteLine("Enter the Book Author Name : ");
                AName = Console.ReadLine();
                Console.WriteLine("Enter the Book Price");
                Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Book Publish Year");
                bYear = int.Parse(Console.ReadLine());
                book[i] = new Book { bName = BName, bAut_Name = AName, Price = Price, bYear = bYear };
            }
            var res = book.GroupBy(b => b.bName).OrderBy(b=>b.Key);
            foreach (var item in res)
            {
                Console.WriteLine("Book Name {0} : Count {1} :  ", item.Key,item.Count());
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.bName+" : "+item1.bAut_Name+" : "+item1.Price+" : "+item1.bYear);
                }
            }
            Console.ReadKey();
        }
    }
     public class Book
    {
        public string bName{ get; set; }
        public string bAut_Name { get; set; }
        public int Price{ get; set; }
        public int bYear { get; set; }
        public  Book()
        {
            this.bName = string.Empty;
            this.bAut_Name = string.Empty;
            this.Price = 0;
        }
        public void SetData(string bname,string Aname,int price )
        {
            
        }
        public void GetData()
        {
            Console.WriteLine("Book Name        : " + bName);
            Console.WriteLine("Book Author Name : " + bAut_Name);
            Console.WriteLine("Book Price       : " + Price);
        }
    }
}
