using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load("C:\\Users\\ahmad\\Desktop\\Data.xml");
            var result = root.Elements("staff").Where(d => d.Attribute("Dep").Value == "M");
            foreach (var item in result)
            {
                Console.WriteLine(item/*.Element("Experience").Value*/);
            }
            Console.WriteLine();
            try
            {

                int[] arr = { 1, 2, 3, 4, 5, 10 ,20};
                var res = arr.First(x => x % 5 == 0);
                Console.WriteLine("Result : " + res);

                var res1 = arr.FirstOrDefault(x=>x%10==0);
                Console.WriteLine("Result : " + res1);
                int[] arr1 = { 1 };

                var res2 = arr1.Single();
                Console.WriteLine("Result : " + res2);

                var res22 = arr.SingleOrDefault(x => x % 10 == 0);
                Console.WriteLine("Result : " + res22);
            }
            catch (Exception ex)
            {

                Console.WriteLine(""+ex);
            }
            Console.ReadKey();
        }
    }
}
