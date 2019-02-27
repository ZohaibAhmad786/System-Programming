using System;
using System.Collections.Generic;
using System.Threading;
namespace DifferentDataBankAssignment
{
    public class DataBankThird
    {
        List<int> dbobj = new List<int>();
        int data;
        public DataBankThird(int data)
        {
            this.data = data;
            for (int i = 12; i <18 ; i++)
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
                Thread.Sleep(r.Next(40, 350));
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