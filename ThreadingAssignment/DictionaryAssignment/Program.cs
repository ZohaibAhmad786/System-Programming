using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Country> dt = new Dictionary<string, Country>();
            Console.WriteLine("Enter your Choice from 1 to 4");
            int ch = int.Parse(Console.ReadLine());
            //Country ct = new Country();


            do
            {
                if (ch == 1)
                {
                    Country ct = new Country();
                    Console.WriteLine("Country Name");
                    ct.cname = Console.ReadLine() ;
                    Console.WriteLine("Country Capital");
                    ct.capital = Console.ReadLine();
                    Console.WriteLine("Country Population");
                    ct.population = int.Parse(Console.ReadLine());
                    if (!dt.ContainsKey(ct.cname))
                    {
                        
                        dt.Add(ct.cname, ct);
                    }
                    else
                    {
                        Console.WriteLine("Already Exist");
                    }
                }
                else if (ch == 2)
                {
                    //delete
                    Country ct = new Country();
                    Console.WriteLine("Country Name for delete");
                    ct.cname = Console.ReadLine();
                    if (dt.ContainsKey(ct.cname))
                    {

                        dt.Remove(ct.cname);
                    }
                    else
                    {
                        Console.WriteLine("Data Are not Inserted Yet");
                    }

                }else if (ch==3)
                {
                    Country ct = new Country();
                    Console.WriteLine("Country Name for search");
                    ct.cname = Console.ReadLine();
                    if (dt.ContainsKey(ct.cname))
                    {
                        foreach (KeyValuePair<string,Country> item in dt)
                        {
                            if (item.Key == ct.cname)
                            {
                                Console.WriteLine(item.Key + " " + item.Value.cname + " " + item.Value.capital);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Are not Inserted Yet");
                    }
                }else if (ch==4)
                {
                    Country ct = new Country();
                    Console.WriteLine("Country Name for search");
                    ct.cname = Console.ReadLine();
                    if (dt.ContainsKey(ct.cname))
                    {
                        dt[ct.cname].cname = "Australia";
                        dt[ct.cname].capital = "Aus";
                        dt[ct.cname].population = 1345;
                    }
                    else
                    {

                    }
                }else if (ch == 5)
                {
                    foreach (KeyValuePair<string, Country> item in dt)
                    {
                       // if (item.Key == ct.cname)
                        ////{
                            Console.WriteLine(item.Key + " Counrty Name" + item.Value.cname + " Capital " + item.Value.capital+" Population "+item.Value.population);
                        //}
                    }
                }
                Console.WriteLine("Enter your Choice from 1 to 4 Again");
                ch = int.Parse(Console.ReadLine());

            } while (ch != 6);
        }
    }
    class Country
    {
        public string cname { get; set; }
        public string capital { get; set; }
        public int population { get; set; }
        
    }
}
