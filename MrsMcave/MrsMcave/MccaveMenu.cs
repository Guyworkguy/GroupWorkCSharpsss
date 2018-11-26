using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MrsMcave
{
    public partial class MccaveMenu : Form
    {
        public MccaveMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child_Form_1 upload = new Child_Form_1();
            upload.Show();
            /*string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
                MessageBox.Show("Mrs.Mccave has found her family!");
            }
            else
            {
                MessageBox.Show("Let's help Mccave with her family problems!");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
            List<Child> Dave = new List<Child>();
            List<string> lines = File.ReadAllLines(path).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split('-');
                Child newChild = new Child();
                newChild.nName = entries[0];
                newChild.bDate = entries[1];
                newChild.lIkes = entries[2];

                Dave.Add(newChild);

            }


            List<DateTime> jo = new List<DateTime>();
            foreach (var Child in Dave)
            {

                DateTime ma = Convert.ToDateTime(Child.bDate);
                jo.Add(ma);

            }
            var today = DateTime.Today;
            int f = jo.Count;
            List<int> agel = new List<int>();
            for (int i = 0; i < f; i++)
            {
                int age = today.Year - jo[i].Year;

                agel.Add(age);
            }
            DateTime dday = today.AddDays(8);

            for (int n = 0; n < f; n++)
            {
                DateTime temp = jo[n];
                while (temp.Year < today.Year)
                {
                    temp = temp.AddYears(1);
                }
                if (temp > today && temp < dday)
                {
                    MessageBox.Show($"{Dave[n].nName}{agel[n]}{Dave[n].lIkes}");
                }
                else
                {
                    MessageBox.Show("Nobodies birthday!");
                    break;

                }
            }*/
            Child_Form_2 two = new Child_Form_2();
            two.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Child_Form_3 tw = new Child_Form_3();
            tw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Child_Form_4 tw = new Child_Form_4();
            tw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Child_Form_5 tw = new Child_Form_5();
            tw.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Child_Form_6 wr = new Child_Form_6();
            wr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Child_Form_7 wr = new Child_Form_7();
            wr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Child_Form_8 welf = new Child_Form_8();
            welf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Child_Form_10 upload = new Child_Form_10();
            upload.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Child_Form_11 charts = new Child_Form_11();
            charts.Show();
        }
    }
}
