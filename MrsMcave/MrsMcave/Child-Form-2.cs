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
    public partial class Child_Form_2 : Form
    {
        public Child_Form_2()
        {
            InitializeComponent();
        }

        private void Child_Form_2_Load(object sender, EventArgs e)
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
                    bBox.Items.Add(Dave[n].nName + agel[n] + Dave[n].lIkes);
                }
                
            }
        }
    }
}
