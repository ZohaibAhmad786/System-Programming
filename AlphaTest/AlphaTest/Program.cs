using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTest
{
    class Program
    {
        //this test is now fully understand now. thanks
        static void Main(string[] args)
        {
            MyClass[] my = new MyClass[2];/*{ new MyClass { _Name="ALi",_Age=22}, new MyClass{_Name="Hamza" ,_Age=24} };*/

            for (int i = 0; i < 2; i++)
            {
                my[i] = new MyClass { _Name = Console.ReadLine(), _Age = int.Parse(Console.ReadLine()) };
            }
            foreach (var item in my)
            {
                Console.WriteLine(item._Name + " :  " + item._Age);
            }
            Console.ReadKey();
        }
        public class MyClass
        {
            private string name;

            public string _Name
            {
                get { return name; }
                set { name = value; }
            }
            private int age;

            public int _Age
            {
                get { return age; }
                set { age = value; }
            }


        }
    }


}
