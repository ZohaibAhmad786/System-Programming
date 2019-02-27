using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultipleJoinsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            List<Book> books = new List<Book>();
            List<StudentCourse> StuCourse = new List<StudentCourse>();
            stu.Add(new Student { Sid = 1, Sname = "Ahmad", Discipline = "BSCS" });
            stu.Add(new Student { Sid = 2, Sname = "Ali", Discipline = "BSIT" });
            stu.Add(new Student { Sid = 3, Sname = "Faraz", Discipline = "BSIT" });
            stu.Add(new Student { Sid = 4, Sname = "Hamza", Discipline = "MCS" });
            stu.Add(new Student { Sid = 5, Sname = "Arshad", Discipline = "MIT" });
            stu.Add(new Student { Sid = 6, Sname = "Usman", Discipline = "MIT" });
            books.Add(new Book { Cid = 1, BName = "C++" });
            books.Add(new Book { Cid = 2, BName = "C++" });
            books.Add(new Book { Cid = 2, BName = "OOP" });
            books.Add(new Book { Cid = 3, BName = "SP" });
            books.Add(new Book { Cid = 4, BName = "CC" });
            books.Add(new Book { Cid = 5, BName = "TA" });
            books.Add(new Book { Cid = 6, BName = "SE" });
            books.Add(new Book { Cid = 1, BName = "TA"});

            StuCourse.Add(new StudentCourse { Cid = 1, Sid=1 });
            StuCourse.Add(new StudentCourse { Cid = 2, Sid=2 });
            StuCourse.Add(new StudentCourse { Cid = 4, Sid=3 });
            var res = stu.Join(StuCourse, s => s.Sid, sc => sc.Sid, (s, sc) => new { StudentInfo = s, Stuc = sc }).Join(books, x => x.Stuc.Cid, b => b.Cid, (x, b) => new { Name = x.StudentInfo.Sname, Title = b.BName });
            //var res = stu.Join(books, s => s.Sid, b => b.Cid, (s, b) => new { StudentInfo = s, BookInfo = b }).Join(StuCourse, b=>b.BookInfo.Cid,c=>c.Cid,(b,c) =>new { Name=b.StudentInfo.Sname,Title=c.Cid});
            foreach (var item in res)
            {

                Console.WriteLine(item/*.Name.ToString() + " :::: " + item.Title.ToString()*/);
            }
            Console.ReadKey();
        }
    }
}
