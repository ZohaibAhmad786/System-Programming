using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace TaskVersion2
{
    public partial class Form1 : Form
    {
        SYSTEMPROGRAMMINGEntities dbase = new SYSTEMPROGRAMMINGEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFirstTask_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbase.Courses.Join(dbase.studentcourses, c => c.Cid, sc => sc.Cid, (c, sc) => new { CCid = c.Cid, CName = c.CTitle, ScSid = sc.Sid }).Join(dbase.Student_1, x => x.ScSid, cour => cour.Sid, (x, cour) => new { CourseId = x.CCid, Title = x.CName, GPA = cour.SCGPA }).OrderBy(d => d.Title).ThenByDescending(d => d.GPA).ToList();   
        }

        private void btnSecondTask_Click(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource*/var res  = dbase.Courses.Join(dbase.studentcourses, c => c.Cid, sc => sc.Cid, (c, sc) => new {Title=c.CTitle}).OrderBy(c=>c.Title).GroupBy(c=>c.Title);
            foreach (var item in res)
            {
                dataGridView1.Rows.Add(item.Key, item.Count());
            }
        }
    }
}
