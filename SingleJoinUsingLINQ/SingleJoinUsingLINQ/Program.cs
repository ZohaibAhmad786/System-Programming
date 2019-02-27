using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleJoinUsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            List<Book> books = new List<Book>();
            stu.Add(new Student { Sid = 1, Sname = "Ahmad", Discipline = "BSCS" });
            stu.Add(new Student { Sid = 2, Sname = "Ali", Discipline = "BSIT" });
            stu.Add(new Student { Sid = 3, Sname = "Faraz", Discipline = "BSIT" });
            stu.Add(new Student { Sid = 4, Sname = "Hamza", Discipline = "MCS" });
            stu.Add(new Student { Sid = 5, Sname = "Arshad", Discipline = "MIT" });
            stu.Add(new Student { Sid = 6, Sname = "Usman", Discipline = "MIT" });
            books.Add(new Book { Sid = 1, BName = "C++", GPA = 3.5f });
            books.Add(new Book { Sid = 2, BName = "C++", GPA = 3.0f });
            books.Add(new Book { Sid = 2, BName = "OOP", GPA = 2.69f });
            books.Add(new Book { Sid = 3, BName = "SP", GPA = 4.0f });
            books.Add(new Book { Sid = 4, BName = "CC", GPA = 2.99f });
            books.Add(new Book { Sid = 5, BName = "TA", GPA = 3.02f });
            books.Add(new Book { Sid = 6, BName = "SE", GPA = 3.29f });
            books.Add(new Book { Sid = 1, BName = "TA", GPA = 3.04f });

            var res = stu.Select(d=>d).Join(books, s => s.Sid, b => b.Sid,(s,b)=>new { StudentInfo=s,BookInfo=b}).Where(d=>d.StudentInfo.Sid>2).GroupBy(d=>d.StudentInfo.Discipline);
            foreach (var item in res)
            {
                //Console.WriteLine(item.StudentInfo.Sid + " :::: " + item.BookInfo.Sid +" :::: "+item.BookInfo.BName+" :::: "+item.BookInfo.GPA);
                Console.WriteLine("Disp : {0}   Count : {1} ",item.Key,item.Count());
            }
            Console.ReadKey();
        }
    }
}
