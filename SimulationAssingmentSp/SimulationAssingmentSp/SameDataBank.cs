using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SimulationAssingmentSp
{
    public class SameDataBank
    {
        List<int> Database = new List<int>();
        private int data;
        public SameDataBank(int data)
        {
            this.data = data;
            for (int i = 0; i < 20; i++)
            {
                Database.Add(i + 1);
            }
        }
        public bool SeachData(object sender)
        {
            var signal = sender as AutoResetEvent;
            var r = new Random();
            for (int i = 0; i < Database.Count; i++)
            {
                Thread.Sleep(r.Next(30, 300));
                if (this.data==Database[i])
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
