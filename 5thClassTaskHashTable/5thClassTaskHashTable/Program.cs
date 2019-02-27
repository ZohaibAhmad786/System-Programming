using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _5thClassTaskHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Hashtable ht1 = new Hashtable();
            ht1.Add("A", 1);
            ht1.Add("B", 1);
            ht1.Add("C", 1);
            foreach (var item in ht1.Keys)
            {
                Console.WriteLine(item + " " + ht[item]);
            }
            Console.WriteLine("Value Removed first one");
            ht1.Remove("A");
            foreach (var item in ht1.Keys)
            {
                Console.WriteLine(item + " " + ht[item]);
            }
            ht1["B"] = "C";
            foreach (var item in ht1.Keys)
            {
                Console.WriteLine(item + " " + ht[item]);
            }
            do
            {
                Console.WriteLine("Enter your country Name for Voting");
                var CName = Console.ReadLine();
                if (CName == string.Empty)
                {
                    break;
                }
                if (ht.Contains(CName) == true)
                {
                    ht[CName] = Convert.ToInt32(ht[CName]) + 1;
                }else
                {
                    ht.Add(CName, 1);
                }

            } while (true);

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item + " " + ht[item]);
            }
            Console.ReadKey();
        }
    }
}
