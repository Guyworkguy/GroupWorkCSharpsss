using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MrsMcave
{
    public partial class Child_Form_3 : Form
    {
        public Child_Form_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
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
                Console.WriteLine(ma);
            }

            var today = DateTime.Today;
            int f = jo.Count;
            List<int> agel = new List<int>();
            List<int> ageL = new List<int>();
            for (int i = 0; i < f; i++)
            {
                int age = today.Year - jo[i].Year;
                agel.Add(age);
                age--;

                ageL.Add(age);
            }
            //2
            DateTime dday = today.AddDays(8);
            var mo = dday.Day - today.Day;

            List<Nameunb> lst = new List<Nameunb>();



            for (int z = 0; z < f; z++)
            {
                lst.Add(new Nameunb(Dave[z].nName, jo[z]));



            }
            //part3
            lst.Sort(delegate (Nameunb x, Nameunb y)
            {
                return x.Total.CompareTo(y.Total);
            });
            for (int i = 0; i < f; i++)
            {
                listBox1.Items.Add(lst[i].Name);
            }
        }

        private void txt_list_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Child_Form_3_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
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
                Console.WriteLine(ma);
            }

            var today = DateTime.Today;
            int f = jo.Count;
            List<int> agel = new List<int>();
            List<int> ageL = new List<int>();
            for (int i = 0; i < f; i++)
            {
                int age = today.Year - jo[i].Year;
                agel.Add(age);
                age--;

                ageL.Add(age);
            }
            //2
            DateTime dday = today.AddDays(8);
            var mo = dday.Day - today.Day;

            List<Nameunb> lst = new List<Nameunb>();



            for (int z = 0; z < f; z++)
            {
                lst.Add(new Nameunb(Dave[z].nName, jo[z]));



            }
            for (int i = 0; i < f; i++)
            {
                listBox2.Items.Add(lst[i].Name);
            }
        
    }
    }
}
