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
namespace _7ThTaskAssignmentDatabase
{
    public partial class Grouping_Assignment : Form
    {
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-98278SF;Initial Catalog=SYSTEMPROGRAMMING;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        SqlDataAdapter sda = null;
        string Query = string.Empty;
        DataSet ds = new DataSet();
       
        DataTable dt = new DataTable();
        public Grouping_Assignment()
        {
            InitializeComponent();
        }

        private void btnLStudata_Click(object sender, EventArgs e)
        {
            sc.Open();
            Query = "select DISCIPLINE,GENDER,MAX(CGPA) as [Max GPA] from STUDENT group by DISCIPLINE,GENDER order by DISCIPLINE asc ";
            cmd = new SqlCommand(Query, sc);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            sc.Close();
        }

        private void btnDispStuData_Click(object sender, EventArgs e)
        {
            dgviewStudentRec.DataSource = ds.Tables[0];
        }
    }
}
