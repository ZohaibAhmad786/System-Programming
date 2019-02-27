using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginationAssignment
{
    public partial class Form1 : Form
    {
        static int Pre = 0;
        static int next = 0;
        int paging = 9;
        static int count = 0;
        static int checking = 0;
        List<Student> stu = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
            dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre).Take(paging).ToList();
            label1.Text = Pre + "----------------" + (paging);
            Pre = next = paging;
        }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (stu.Count() > (next + paging))
            {
                int p = Pre;
                int n = next;
                next += paging;

                dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }
            else
            {
                Pre = next;
                next = stu.Count();
                dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (stu.Count() > Pre && Pre < paging)
            {
                //int a = paging;
                //int aa = next;
                //int aaa = Pre;
                //paging = next - paging;

                Pre = 0;
                //paging = Pre - paging;
                dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre).Take(next).ToList();
                label1.Text = Pre + "----------------" + (next);
                Pre = next;
            }
            else
            {
                dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre - paging).Take(paging).ToList();
                label1.Text = (Pre - paging) + "----------------" + (Pre);
                Pre -= paging;
                next = Pre;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Pre = count = stu.Count();
            dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre - paging).Take(paging).ToList();
            label1.Text = (Pre - paging) + "----------------" + (Pre);
            Pre -= paging;
            next = Pre;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (stu.Count() > 0)
            {
                Pre = 0;
                dataGridView1.DataSource = stu.OrderBy(d => d.AridNo).Skip(Pre).Take(paging).ToList();
                label1.Text = Pre + "----------------" + (paging);
                Pre = next = paging;
            }
            else
            {
                MessageBox.Show("NO Record Found");
            }
        }
        public void FillList()
        {
            // List<Student> stu = new List<Student>();
            stu.Add(new Student { AridNo = "14 - ARID - 0047", Name = "Uzair Mumtaz" });
            stu.Add(new Student
            {
                AridNo = "14 - ARID - 0074  ",
                Name = "  MUBASHAR AHMAD"
            });
            stu.Add(new Student
            {
                AridNo = "14 - ARID - 0098  ",
                Name = "  MUHAMMAD WAJAHAT YOUSAF"
            });
            stu.Add(new Student
            {
                AridNo = "14 - ARID - 0715 ",
                Name = "   SHAHZAIB"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 0023 ",
                Name = "   AMEER HAMZA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 0048 ",
                Name = "   JIBRAN HAIDER"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 0083",
                Name = "    MUHAMMAD WASEEM ARSHAD"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 0107 ",
                Name = "   UMER MUSTAFA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2228  ",
                Name = "  AAMIR HUSSAIN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2240  ",
                Name = "  AHTSHAM HABIB"
            });

            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2243  ",
                Name = "  ALLAH WASAYA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2244  ",
                Name = "  AMIR SOHAIL"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2248  ",
                Name = "  ANEEQA NASEEM"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2249  ",
                Name = "  ANIQA AYUB"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2259  ",
                Name = "  ASSAAM YASIN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2260  ",
                Name = "  ATIF MANZOOR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2267  ",
                Name = "  FAHAD NAZIR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2269 ",
                Name = "   FAIZAN AKHTAR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2277  ",
                Name = "  HAFIZA SAIRA SHAHEEN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2278  ",
                Name = "  HAIDER ALI KHAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2281  ",
                Name = "  HAMZA ARSHAD"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2289  ",
                Name = "  HUZAIFA BIN ZAMEER PARACHA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2294  ",
                Name = "  JUNAID AHMAD"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2298  ",
                Name = "  KHALEEQ - UR - REHMAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2306  ",
                Name = "  MIRZA NABEEL AHMED"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2310   ",
                Name = " MOIN AHMED"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2314  ",
                Name = "  MUHAMMAD AHMAR WAQAR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2317  ",
                Name = "  MUHAMMAD ASAD KHAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2320  ",
                Name = "  MUHAMMAD ASIM"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2323  ",
                Name = "  MUHAMMAD AWAIS ALI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2326",
                Name = "MUHAMMAD DANIYAL NASEER JANJUA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2332 ",
                Name = "   MUHAMMAD HAMZA"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2353  ",
                Name = "  MUHAMMAD UMAIR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2360  ",
                Name = "  MUHAMMAD ZUBAIR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2363  ",
                Name = "  NAUMAN ISHAQUE"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2365  ",
                Name = "  NOMAN BUTT"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2368  ",
                Name = "  NOUMAN SABIR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2378  ",
                Name = "  SAIM RIZWAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2379   ",
                Name = " SAJID ALI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2380  ",
                Name = "  SAJID ALI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2398 ",
                Name = "   SYED HASSAAN AHMAD"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2401 ",
                Name = "   SYED MUHAMMAD ALI FRAZ BUKHARI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2402  ",
                Name = "  SYED MUHAMMAD HUSSNAIN HAIDER"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2407  ",
                Name = "  SYED ZAKAWAT  SAEED"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2408  ",
                Name = "  SYEDA NOSHEED BADAR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2427  ",
                Name = "  ZOHAIB AHMAD"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2449  ",
                Name = "  ARSALA SHAHZADI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2456 ",
                Name = "   FAIZAN ALI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2460  ",
                Name = "  HABIB SULTAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2464  ",
                Name = "  HASEEB AHMED"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2470 ",
                Name = "   EJAZ ALI"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2500  ",
                Name = "  MUHAMMAD HAMZA ALAM"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2504  ",
                Name = "  MUHAMMAD KAMRAN"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2509  ",
                Name = "  MUHAMMAD UMAIR TASAWAR"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2524  ",
                Name = "  SAIRA KHURSHID"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2530  ",
                Name = "  SHAYAN TARIQ"
            });
            stu.Add(new Student
            {
                AridNo = "15 - ARID - 2546 ",
                Name = "   ZIA UR REHMAN"
            });

        }
    }
}