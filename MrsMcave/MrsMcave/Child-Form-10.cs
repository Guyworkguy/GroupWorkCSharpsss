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


    public class milestones
    {
        
    }
    public partial class Child_Form_10 : Form
    {
        public Child_Form_10()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txt_Enter.Text;
                int inputyear = Convert.ToInt32(text);


                // MessageBox.Show(text);

                // string text = txt_Enter.Text;
                //  DateTime tempage = Convert.ToDateTime();

                //  DateTime value = Convert.ToDateTime(txt_Enter.Text);

                string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
                List<Child> Dave = new List<Child>();
                List<string> lines = File.ReadAllLines(path).ToList();
                // List<string> ww = new List<string>();
                foreach (var line in lines)
                {
                    string[] entries = line.Split('-');
                    Child newChild = new Child();
                    newChild.nName = entries[0];
                    newChild.bDate = entries[1];
                    newChild.lIkes = entries[2];

                    Dave.Add(newChild);


                    // ww.Add(line);


                }
                List<DateTime> jo = new List<DateTime>();
                foreach (var Child in Dave)
                {

                    DateTime ma = Convert.ToDateTime(Child.bDate);
                    jo.Add(ma);
                    Console.WriteLine(ma);
                }

                var today = DateTime.Today;

                DateTime t = new DateTime(inputyear, 7, 10);
                int f = jo.Count;
                List<int> agel = new List<int>();
                List<int> ageL = new List<int>();
                for (int i = 0; i < f; i++)
                {
                    int age = t.Year - jo[i].Year;
                    agel.Add(age);
                    age--;

                    ageL.Add(age);

                }
                List<int> Ages = new List<int>();
                List<int> Others = new List<int>();

                DateTime sept = new DateTime(today.Year, 9, 1);
                for (int i = 0; i < f; i++)
                {
                    int kid;
                    if (sept.Month < jo[i].Month)
                    {
                        kid = ageL[i];
                    }
                    else
                    {
                        kid = agel[i];
                    }
                    Ages.Add(kid);

                }
                /* for (int i = 0; i < f; i++)
                 {
                     int temp = Ages[i];
                     temp = +Ages[i] - t.Year;
                     Others.Add(temp);
                 }*/
                string g = Convert.ToString(Ages[0]);
                //MessageBox.Show(g);

                int preschool = 0, primary = 0, secondary = 0, college = 0, finished = 0;
                for (int i = 0; i < f; i++)
                {

                    if (Ages[i] < 5)
                    {
                        preschool++;
                    }
                    else if (Ages[i] >= 5 && Ages[i] < 13)
                    {
                        primary++;
                    }
                    else if (Ages[i] >= 13 && Ages[i] < 19)
                    {
                        secondary++;
                    }
                    else if (Ages[i] >= 19 && Ages[i] < 24)
                    {
                        college++;
                    }
                    else
                    {
                        finished++;
                    }
                }
                string pre = Convert.ToString(preschool);

                string pri = Convert.ToString(primary);
                string sec = Convert.ToString(secondary);
                string col = Convert.ToString(college);
                string fin = Convert.ToString(finished);
                txt_Preschool.Text = pre;
                txt_Primary.Text = pri;
                txt_Secondary.Text = sec;
                txt_College.Text = col;
                txt_Finished.Text = fin;
            }
            catch
            {
                MessageBox.Show("Please enter a valid year.");
            }
        }
    }
}
