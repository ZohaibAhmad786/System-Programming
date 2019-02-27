using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Gender",typeof(char));
            dt.Columns.Add("GPA",typeof(float));
            dt.Columns.Add("Discipline",typeof(string));
            dt.Rows.Add("Ahmad", "M", 3.9f, "BSCS");
            dt.Rows.Add("Hamza", "M", 3.25f, "BSCS");
            dt.Rows.Add("Arslan", "M", 3.0f, "BSIT");
            dt.Rows.Add("Kamran", "M", 1.25f, "BSIT");
            dt.Rows.Add("Shayan", "M", 2.68f, "MSIT");
            dt.Rows.Add("Uzma", "F", 2.87f, "MSCS");
            dt.Rows.Add("Ifra", "F", 2.98f, "MSCS");
            dt.Rows.Add("Fatima", "F", 3.54f, "BSIT");
            dt.Rows.Add("Hussnain", "M", 3.57f, "BSCS");
            dt.Rows.Add("Hasam", "M", 2.0f, "MSIT");
            #region Datatable
            foreach (var item in dt.AsEnumerable().OrderBy(d=>d.Field<float>("GPA")))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().GroupBy(d=>d.Field<string>("Discipline")))
            {
                Console.WriteLine("Discipline : {0} ,NO of Student in each Discipline : {1} :: ", item.Key, item.Count());
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().GroupBy(d => d.Field<string>("Discipline")).OrderBy(d=>d.Key).ToList())
            {
                Console.WriteLine("Discipline : {0} ,Max GPA each Group: {1} :: ", item.Key, item.Max(d => d.Field<float>("GPA")));
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().Where(d => d.Field<string>("Name").ToLower().Contains("a")))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().Where(d => d.Field<string>("Name").ToLower().StartsWith("a")))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().Where(d => d.Field<float>("GPA") > 2.0f && d.Field<float>("GPA") < 4.0f))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            float result = dt.AsEnumerable().Max(d => d.Field<float>("GPA"));
            Console.WriteLine(result);
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().Where(d => d.Field<string>("Name").ToLower().EndsWith("n")))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            foreach (var item in dt.AsEnumerable().Where(d => d.Field<char>("Gender") == 'F').OrderBy(d => d.Field<string>("Name")))
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.Field<string>("Name"), item.Field<char>("Gender"), item.Field<float>("GPA"), item.Field<string>("Discipline"));
            }
            Console.WriteLine();
            #endregion
            #region  List
            
            List<Student> stu = dt.AsEnumerable().Select(d=> new Student { name=d.Field<string>("Name"),gender=d.Field<char>("Gender"),gpa=d.Field<float>("GPA"),discipline=d.Field<string>("Discipline")}).ToList();
            Console.WriteLine();
            Console.WriteLine("            1   :: select * from student order by GPA asc");
            var res = stu.OrderBy(d => d.gpa);
            foreach (var item in res)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ",item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            2   :: select discipline ,count(*) from student group by discipline");
            var res1 = stu.GroupBy(d=>d.discipline);
            foreach (var item in res1)
            {
                Console.WriteLine("Discipline : {0} ,NO of Student in each Discipline : {1} :: ",item.Key,item.Count());
            }
            Console.WriteLine();
            Console.WriteLine("            3   :: select discipline from student group by GPA order by discipline asc");
            var res2 = stu.GroupBy(d => d.discipline).OrderBy(d=>d.Key);
            foreach (var item in res2)
            {
                Console.WriteLine("Discipline : {0} ,Max GPA each Group: {1} :: ", item.Key, item.Max(d=>d.gpa));
            }
            Console.WriteLine();
            Console.WriteLine("            4   :: select * from student where GPA>2.5");
            var res3 = stu.Where(d=>d.gpa>2.0);
            foreach (var item in res3)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            5   :: select * from student where Name like %a%");
            var res4 = stu.Where(d => d.name.ToLower().Contains("a"));
            foreach (var item in res4)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            6   :: select * from student where Name like a%");
            var res5 = stu.Where(d => d.name.ToLower().StartsWith("a"));
            foreach (var item in res5)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            7   :: select * from student where  GPA between 2.5 and 4.0 ");
            var res6 = stu.Where(d => d.gpa>2.0f && d.gpa<4.0f);
            foreach (var item in res6)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            8   :: select MAx(GPA) from student ");
            float res7 = stu.Max(d => d.gpa);

            Console.WriteLine("MAX GPA:: "+ res7);
            Console.WriteLine();
            Console.WriteLine("            9   :: select * from student where Name like %n ");
            var res8 = stu.Where(d => d.name.ToLower().EndsWith("n"));
            foreach (var item in res8)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            Console.WriteLine("            10  :: select * from student where gender='F' order by name asc ");
            var res9 = stu.Where(d => d.gender=='F').OrderBy(d=>d.name);
            foreach (var item in res9)
            {
                Console.WriteLine("Name : {0} ,Gender : {1} , GPA : {2} , Discipline : {3} :: ", item.name, item.gender, item.gpa, item.discipline);
            }
            Console.WriteLine();
            
            #endregion



            Console.ReadKey();
        }
    }
}
