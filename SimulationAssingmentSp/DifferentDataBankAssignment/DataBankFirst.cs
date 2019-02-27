using System;
using System.Collections.Generic;
using System.Threading;
namespace DifferentDataBankAssignment
{
    public class DataBankFirst
    {
        List<int> dbobj = new List<int>();
        int data;
        public DataBankFirst(int data)
        {
            this.data = data;
            for (int i = 1; i < 15; i++)
            {
                dbobj.Add(i);
            }
        }
        public bool SearchData(object sender)
        {
            var signal = sender as AutoResetEvent;
            var r = new Random();
            for (int i = 0; i < dbobj.Count; i++)
            {
                Thread.Sleep(r.Next(20, 150));
                if (this.data == dbobj[i])
                {
                    signal.Set();
                    return true;
                }
            }
            signal.Set();
            return false;
        }
    }
}