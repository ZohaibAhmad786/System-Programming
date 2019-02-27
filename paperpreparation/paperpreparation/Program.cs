using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace paperpreparation
{

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var ini = new Monitor();
    //        ini.GeneratingRandonNumebrs += DisplayNumbers;

    //        ini.readData();
    //    }

    //    public static int DisplayNumbers(int v,string s)
    //    {
    //        //Console.WriteLine(s+" Generated Number : " + v);
    //        return v;
    //    }
    //}
    //class Monitor
    //{
    //    public delegate int  warning(int v,string s);
    //    public event warning GeneratingRandonNumebrs;
    //    public void readData()
    //    {
    //        var v = new Random();
    //        int data;
    //        while (true)
    //        {

    //            data = v.Next(1, 500);
                
    //            Console.WriteLine(GeneratingRandonNumebrs(data, "hi"));
    //            Thread.Sleep(1000);
    //        }
    //    }
    //}
    class Program
    {


        public delegate void Myaction();
        public delegate t Myaction2<t,t1>(t x);
        static void Main(string[] args)
        {
            Action a = delegate () { Console.WriteLine("hello"); };
            a.Invoke();

            Action<int> ab = (int x) => { Console.WriteLine("hello" + x); };
            ab.Invoke(3);

            Action<int, string> ac = delegate (int x, string y) { Console.WriteLine("hello" + x + " " + y); };
            ac.Invoke(3, "hell");


            Func<int> ad = delegate () { return 3; };
            Console.WriteLine(ad.Invoke());
            student st = new student();
            st.id = 1;

            Func<int, int, int> a3 = (x, y) => { return x + y; };
            Console.WriteLine(a3.Invoke(3, 5));
            Myaction addd = add;
            addd.Invoke();
            Myaction2<int, int> hsh = st.add;
            hsh.Invoke(10);
            //Action a = add;
            //a.Invoke();
            //Func<int,int,int> b = add2;

            Console.WriteLine(hsh.Invoke(10));

            
            //Action ab= st.disp;
            //ab.Invoke();
            //Func<int, int> aa = st.add;
            //Console.WriteLine(   aa.Invoke(st.id));
            Console.ReadKey();
        }
        public static void add()
        {
            Console.WriteLine("Hello");
        }
        public static t add2<t>(t x, t y)
        {

            return x;
        }
    }
    class student
    {
        public int id { get; set; }
        public student()
        {

        }
        public void disp()
        {
            Console.WriteLine("he");
        }
        public int add(int id)
        {
            return id;
        }
    }
}
