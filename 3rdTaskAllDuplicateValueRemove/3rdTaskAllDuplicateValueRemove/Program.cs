using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _3rdTaskAllDuplicateValueRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(10);
            al.Add(10);
            al.Add(40);
            al.Add(50);
            al.Add(30);
            al.Add(60);
            al.Add(40);
            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].ToString() == al[j].ToString())
                    {
                        al.Remove(al[j]);
                    }
                }
            }
            foreach (var item in al)
            {
                Console.WriteLine(""+ item);
            }
            Console.ReadKey();
        }
        

    }

    //class MyArrayList : ArrayList
    //{
    //    public  void RemoveDuplicate(ICollection  c)
    //    {
    //        for (int i = 0; i < c.Length; i++)
    //        {
    //            for (int j = i + 1; j < c.Length; j++)
    //            {
    //                if (c[i].ToString() == c[j].ToString())
    //                {
    //                    c.(c[j]);
    //                }
    //            }
    //        }
    //    }
    //}
}
