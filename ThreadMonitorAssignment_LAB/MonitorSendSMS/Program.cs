using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MonitorSendSMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool fl = true;
            int i = 2;
            Console.WriteLine("Enter a Number ");
            n=int.Parse(Console.ReadLine());
            do
            {
                if (n % i == 0 && n!=2)
                {
                   
                    fl = false;
                    break;
                }
                else
                {
                   
                    fl = true;
                    break;
                }
                i++;
            } while (i <= n / 2);

            if (fl == false)
            {
                Console.WriteLine("no is not prime");

            }
            else
            {
                Console.WriteLine("no is prime");

            }
            //var ini = new Monitor();
            //ini.Onlowdata += Sendsms;
            //ini.onHighData += SendHigh;
            ////ini.onHighData += Ini_onHighData;
            //ini.readData(1, 30, 1);



            Console.ReadKey();

        }

        //private static void Ini_onHighData(int v)
        //{
        //    throw new NotImplementedException();
        //}

        public static void SendHigh(int v)
        {
            Console.WriteLine("high " +v);
        }
        public static void Sendsms(int v)
        {
            Console.WriteLine("Low "+ v);
        }
    }
    class Monitor
    {
        public delegate void warning(int v);
        public event warning Onlowdata;
        public event warning onHighData;
        public void readData(int startval, int endval, int interval)
        {
            var v = new Random();
            int data;
            while (true)
            {
                data = v.Next(startval, endval);
                if (data<=20)
                {
                    Onlowdata(data);
                    Console.WriteLine("Low Data");
                }
                if (data>20)
                {
                    onHighData(data);
                    Console.WriteLine("High Data");
                }
                Thread.Sleep(interval * 300);
            }
        }
    }
}
