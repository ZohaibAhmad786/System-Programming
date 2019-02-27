using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace LabAssignmentTask
{
    public partial class Form1 : Form
    {
        MonitorClass ini = new MonitorClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            int sv = int.Parse(txtstartValue.Text);
            int ev = int.Parse(txtendValue.Text);
            int iv = int.Parse(txtintervalValue.Text);
            
            var ts = new ThreadStart(delegate ()
            {

                ini.readData(sv, ev, iv);
            });

            var t = new Thread(ts);
            t.Start();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new frmLogger(ini).Show();
        }
    }
}
