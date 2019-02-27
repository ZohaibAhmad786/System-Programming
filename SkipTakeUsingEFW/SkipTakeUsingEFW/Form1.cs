using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SkipTakeUsingEFW
{
    public partial class Form1 : Form
    {
        SYSTEMPROGRAMMINGEntities dbase = new SYSTEMPROGRAMMINGEntities();
        static int Pre = 0;
        static int next = 0;
        int paging = 9;
        static int count = 0;
        static int checking=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //checking = (dbase.STUDENTs.Count() > paging) > paging ? paging : dbase.STUDENTs.Count() - paging;
            dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre).Take(paging).ToList();
            label1.Text = Pre + "----------------" + (paging);
            Pre = next = paging;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            //dgv.Rows.Clear();
            if (dbase.STUDENTs.Count() > (next+paging))
            {
                int p = Pre;
                int n = next;
                next += paging;

                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }else
            {
                Pre =  next;
                next = dbase.STUDENTs.Count();
                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (dbase.STUDENTs.Count() > Pre && Pre < paging)
            {
                //int a = paging;
                //int aa = next;
                //int aaa = Pre;
                //paging = next - paging;
                
                Pre = 0;
                //paging = Pre - paging;
                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre).Take(next).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }
            else
            {
                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre - paging).Take(paging).ToList();
                label1.Text = (Pre - paging) + "----------------" + (Pre);
                Pre -= paging;
                next = Pre;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dbase.STUDENTs.Count()>0)
            {
                Pre = 0;
                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (paging);
                Pre = next = paging;
            }else
            {
                MessageBox.Show("NO Record Found");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
           
            
                Pre = count = dbase.STUDENTs.Count();
                dgv.DataSource = dbase.STUDENTs.OrderBy(d => d.ARID_NO).Skip(Pre - paging).Take(paging).ToList();
                label1.Text = (Pre - paging) + "----------------" + (Pre);
                Pre -= paging;
                next = Pre;
            

        }
    }
}
