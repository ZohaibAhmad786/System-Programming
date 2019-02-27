using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace _7ThTaskAssignmentDatabase
{
    public partial class LabTask2 : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-98278SF;Initial Catalog=SYSTEMPROGRAMMING;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        SqlDataAdapter sda = null;
        string Query = string.Empty;
        DataSet ds = new DataSet();
        static int Pre = 1;
        DataTable dt = new DataTable();
        static int next = 5;
        static int i = 1;
        public LabTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.AsEnumerable().Skip((Pre-5)).Take(5).CopyToDataTable();

            label1.Text = (Pre-5) + "----------------" + (Pre);
            //i--;
            
            Pre -= 5;
            next = Pre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = Pre;
            int c = next;
            next += 5;
            //Pre = next;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt.AsEnumerable().Skip(Pre).Take(5).CopyToDataTable();
            }
            
            label1.Text = Pre + "----------------" + (next);
           
            Pre = next;
            //next = 5;
            i++;
            
            
        }

        private void LabTask2_Load(object sender, EventArgs e)
        {
            sc.Open();
            Query = "Select Arid_No,Full_Name,Age,CGPA from Student";
            cmd = new SqlCommand(Query, sc);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            dataGridView1.DataSource = dt.AsEnumerable().Take(next).CopyToDataTable();
            label1.Text = Pre + "----------------" + (next *i);
            i++;
            Pre = next;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
