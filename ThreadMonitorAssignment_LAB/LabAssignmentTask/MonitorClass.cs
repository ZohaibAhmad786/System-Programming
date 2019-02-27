using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace LabAssignmentTask
{
   public class MonitorClass
    {
        bool flag = false;
        int j = 2;
        public delegate void warning(int v, string dt);
        public event warning ODD;
        public event warning EVEN;
        public event warning PRIME;
        public event warning ALL;
        public void readData(int startval, int endval, int interval)
        {
            var v = new Random();
            int data;

            while (true)
            {
                data = v.Next(startval, endval);
                if (ODD!=null)
                {
                    if (data % 2 != 0)
                    {
                        //odd
                        ODD(data, DateTime.Now.ToShortDateString().ToString() + "" + DateTime.Now.ToLongTimeString());
                    }
                }
                if (EVEN != null)
                {
                    if (data % 2 == 0)
                    {
                        EVEN(data, DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToLongTimeString());
                        //even
                    }
                }
                if (PRIME != null)
                {
                    do
                    {
                        if (data % j == 0 && data != 2)
                        {

                            flag = false;
                            break;
                        }
                        else
                        {

                            flag = true;
                            break;
                        }
                        j++;
                    } while (j <= data / 2);

                    if (flag == false)
                    {
                        // Console.WriteLine("no is not prime");

                    }
                    else
                    {
                        PRIME(data, DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToLongTimeString());
                        // Console.WriteLine("no is prime");

                    }
                }
                if (ALL != null) {
                    ALL(data, DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToLongTimeString());
                }
                Thread.Sleep(interval * 1000);
            }
        }
    }

}
