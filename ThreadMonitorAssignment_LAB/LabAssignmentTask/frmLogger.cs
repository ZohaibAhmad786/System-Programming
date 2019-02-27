using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAssignmentTask
{
    public partial class frmLogger : Form
    {
        public  MonitorClass ini;

        public frmLogger()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public frmLogger(MonitorClass ini)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.ini = ini;
        }

       
        private void frmLogger_Load(object sender, EventArgs e)
        {
            ini.ALL += GetAllData;
            ini.ODD += OddData;
            ini.EVEN += EvenData;
            ini.PRIME += PrimeData;
        }

        private void PrimeData(int v, string dt)
        {
            dataGridView1.Rows.Add(v, dt);
            Application.DoEvents();
        }

        private void EvenData(int v, string dt)
        {
            dataGridView2.Rows.Add(v, dt);
            Application.DoEvents();
        }

        private void OddData(int v, string dt)
        {
            dataGridView3.Rows.Add(v, dt);
            Application.DoEvents();
        }

        private void GetAllData(int v, string dt)
        {
            dataGridView4.Rows.Add(v, dt);
            Application.DoEvents();
        }
    }
}
