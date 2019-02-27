using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _7ThTaskAssignmentDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-98278SF;Initial Catalog=SYSTEMPROGRAMMING;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        SqlDataAdapter sda = null;
        string Query = string.Empty;
        DataSet ds = new DataSet();
        static int count = 1;
        DataTable dt = new DataTable();
        static int dat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sc.Open();
            Query = "Select Arid_No,Full_Name,City from Student";
            cmd = new SqlCommand(Query, sc);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            //dgvDispRecord.DataSource = ds.Tables[0];
        }

        private void btnLoadRecord_Click(object sender, EventArgs e)
        {
            count = 0;

            dgvDispRecord.Rows.Clear();
            try
            {
                dat = int.Parse(txtRec.Text);
                if (dt.Rows.Count > 0 && dt.Rows.Count != dat)
                {
                    for (int i = count; i < dat; i++)
                    {
                        dgvDispRecord.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString());
                    }
                }
                lblPagination.Text = count + "----------------" + dat;
                count = dat;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Input Integer(Numeric) Number. ");
            }
        }

        private void btnNextRec_Click(object sender, EventArgs e)
        {
            dgvDispRecord.Rows.Clear();

            dat += int.Parse(txtRec.Text);
            if (dat <= 100)
            {
                if (dt.Rows.Count > count)
                {
                    for (int i = count; i < dat; i++)
                    {
                        dgvDispRecord.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString());
                    }
                }
                lblPagination.Text = (count + 1) + "----------------" + dat;
                count = dat;
            }
            else
            {
                MessageBox.Show("Record not Exist");
            }
        }

        private void btnPreviousRec_Click(object sender, EventArgs e)
        {
            count = count - (int.Parse(txtRec.Text));
            int d = dat;
            dgvDispRecord.Rows.Clear();
            int c = int.Parse(txtRec.Text);
            dat -= c;
            count = count - c + 1;

            if (count == c || c < 1)
            {
                count = 0;
            }
            count--;
            if (count >= 0)
            {

                //dat = count;
                if (dt.Rows.Count > count)
                {
                    for (int i = count; i < dat; i++)
                    {
                        dgvDispRecord.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString());
                    }
                }
                lblPagination.Text = (count + 1) + "----------------" + dat;
                count = dat;
            }
            else
            {
                MessageBox.Show("Record not Exist");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dgvDispRecord.Rows.Clear();
            count = 0;
            dat = 0;
        }
    }
}
