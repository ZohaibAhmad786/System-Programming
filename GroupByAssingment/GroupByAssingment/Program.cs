using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GroupByAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                s[i].getData(Console.ReadLine(), Console.ReadLine(), float.Parse(Console.ReadLine()), Console.ReadLine(), Convert.ToChar( Console.ReadLine()));
            }
            for (int i = 0; i < 5; i++)
            {
                s[i].disData();
            }
        }
      public   class Student
        {
            string regno;
            string name;
            float gpa;
            string discipline;
            char gender;
            public void getData(string r,string n,float g,string d,char gen)
            {
                regno = r;
                name = n;
                gpa = g;
                discipline = d;
                gender = gen;
            }
            public void disData()
            {
                Console.WriteLine("RegNo.           : " + regno);
                Console.WriteLine("Name             : " + name);
                Console.WriteLine("GPA              : " + gpa);
                Console.WriteLine("Discipline       : " + discipline);
                Console.WriteLine("Gender           : " + gender);
                Console.WriteLine("===========================================");
            }
        }
        
    }
    

}
