using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HashTableVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            bool res = false;
            string name;
            #region Input and Display
            Console.WriteLine("Taking input in HashTable ");
            Hashtable ht = new Hashtable();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your Id : ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Enter your Name : ");
                name = Console.ReadLine();
                ht.Add(id, name);
            }
            ht.Add(1, "Hamza");
            ht.Add(2, "Ali");
            ht.Add(3, "Kamran");
            ht.Add(4, "Usman");
            ht.Add(5, "Arshad");
            ht.Add(6, "Fahad");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Id :: {0}    Name :: {1}  ; ", item, ht[item]);
            }

            #endregion
            #region Data Exit Or Not
            Console.WriteLine();
            Console.WriteLine("Taking input from use if data exist then Show");
            Console.WriteLine();
            Console.Write("Input use ID ");
            id = int.Parse(Console.ReadLine());
            foreach (var item in ht.Keys)
            {
                if (item.Equals(id))
                {
                    Console.WriteLine("Id :: {0}    Name :: {1}  ; ", item, ht[item]);
                    res = true;
                }

            }
            #endregion
            #region User Find
            Console.Write("Enter User Name ");
            name = Console.ReadLine();

            foreach (var item in ht.Values)
            {
                if (item.Equals(name))
                {
                    Console.WriteLine("  Name :: {0}  ; ", item);
                    res = true;
                }

            }
            if (res != true)
                Console.WriteLine("Data not Exist");
            #endregion

            #region Remove Data Using Key
            Console.WriteLine();
            Console.WriteLine("Remove Data from Hashtable");


            ht.Remove(id);
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Id :: {0}    Name :: {1}  ; ", item, ht[item]);
            }
            #endregion

            #region Change Hashtable value Using Key
            Console.WriteLine();
            Console.WriteLine("How to change value of Key");

            Console.Write("Enter Key to Change user Name ");
            id = int.Parse(Console.ReadLine());
            if (ht.ContainsKey(id))
                ht[id] = "Usman";

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Id :: {0}    Name :: {1}  ; ", item, ht[item]);
            }
            #endregion


            #region Value Exist or Not
            Console.WriteLine();
            Console.WriteLine("Contains Value");
            Console.Write("Enter Key to Change user Name ");
            name = Console.ReadLine();
            if (ht.ContainsValue(name))
            {
                Console.WriteLine("Data Exist as Name {0}", name);
            }
            else
            {
                Console.WriteLine("Data Does Not Exist as Name {0}", name);
            }
            #endregion
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
