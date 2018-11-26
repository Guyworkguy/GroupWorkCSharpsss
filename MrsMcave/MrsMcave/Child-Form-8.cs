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
    public partial class Child_Form_8 : Form
    {
        public Child_Form_8()
        {
            InitializeComponent();
        }

        private void welMon_Click(object sender, EventArgs e)
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
            List<Nameunb> ast = new List<Nameunb>();
            for (int z = 0; z < f; z++)
            {
                ast.Add(new Nameunb(Dave[z].nName, jo[z]));
            }
            List<string> twins = new List<string>();
            List<string> triplets = new List<string>();
            List<string> quads = new List<string>();
            for (int y = 0; y < f; y++)
            {
                for (int ad = 0; ad < f; ad++)
                {
                    for (int ag = 0; ag < f; ag++)
                    {
                        for (int ab = 0; ab < f; ab++)
                        {
                            if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name && ast[y].Total == ast[ag].Total && ast[y].Name != ast[ag].Name && ast[ad].Name != ast[ag].Name && ast[ad].Name != ast[ab].Name && ast[ag].Name != ast[ab].Name && ast[y].Name != ast[ab].Name && ast[y].Total == ast[ab].Total)
                            {
                                quads.Add(ast[y].Name);
                            }
                        }
                        if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name && ast[y].Total == ast[ag].Total && ast[y].Name != ast[ag].Name && ast[ad].Name != ast[ag].Name)
                        {
                            triplets.Add((ast[y].Name));
                        }

                    }
                    if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name)
                    {

                        twins.Add((ast[y].Name));
                    }
                }
            }
            var fsecondNotFirst = triplets.Except(quads).ToList();
            var secondNotFirst = twins.Except(triplets).ToList();
            var uniqueItemsList = fsecondNotFirst.Distinct().ToList();
            var suniqueItemsList = secondNotFirst.Distinct().ToList();
            var muniqueItemsList = quads.Distinct().ToList();
            var startDate = new DateTime(today.Year, today.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            int total = 0;
            for (int n = 0; n < f; n++)
            {
                DateTime temp = ast[n].Total;
                DateTime latter = ast[n].Total.AddMonths(1);
                int wel = 140;
                if (muniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                {
                    wel = wel + 140;
                }
                if (uniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                {
                    wel = wel + 140;
                }
                if (suniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                {
                    wel = wel + 70;
                }
                while (temp.Year < startDate.Year)
                {
                    temp = temp.AddYears(1);
                }

                if (/*temp >= startDate &&*/ temp <= endDate)
                {
                    if (temp >= startDate && temp <= endDate)
                    {
                        wel = wel;
                    }
                    else
                    {
                        if (agel[n] >= 18)
                        {
                            wel = 0;
                        }
                    }
                }
                if (ast[n].Total.Year==today.Year)
                {
                    if (ast[n].Total.Month<=today.Month)
                    {
                        wel = 0;
                    }
                    else if(latter.Month==today.Month)
                    {
                        wel = wel + 140;
                    }
                  
                }
                if (ageL[n] >= 18)
                {
                    wel = 0;
                }
                else
                {
                    total = total + wel;

                }

            }
            string totall = Convert.ToString(total);
            MessageBox.Show("The total welfare the Mccave household gained this month is: " + totall);
        }

        private void welYear_Click(object sender, EventArgs e)
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
            List<Nameunb> ast = new List<Nameunb>();
            for (int z = 0; z < f; z++)
            {
                ast.Add(new Nameunb(Dave[z].nName, jo[z]));
            }
            List<string> twins = new List<string>();
            List<string> triplets = new List<string>();
            List<string> quads = new List<string>();
            for (int y = 0; y < f; y++)
            {
                for (int ad = 0; ad < f; ad++)
                {
                    for (int ag = 0; ag < f; ag++)
                    {
                        for (int ab = 0; ab < f; ab++)
                        {
                            if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name && ast[y].Total == ast[ag].Total && ast[y].Name != ast[ag].Name && ast[ad].Name != ast[ag].Name && ast[ad].Name != ast[ab].Name && ast[ag].Name != ast[ab].Name && ast[y].Name != ast[ab].Name && ast[y].Total == ast[ab].Total)
                            {
                                quads.Add(ast[y].Name);
                            }
                        }
                        if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name && ast[y].Total == ast[ag].Total && ast[y].Name != ast[ag].Name && ast[ad].Name != ast[ag].Name)
                        {
                            triplets.Add((ast[y].Name));
                        }

                    }
                    if (ast[y].Total == ast[ad].Total && ast[y].Name != ast[ad].Name)
                    {

                        twins.Add((ast[y].Name));
                    }
                }
            }
            var fsecondNotFirst = triplets.Except(quads).ToList();
            var secondNotFirst = twins.Except(triplets).ToList();
            var uniqueItemsList = fsecondNotFirst.Distinct().ToList();
            var suniqueItemsList = secondNotFirst.Distinct().ToList();
            var muniqueItemsList = quads.Distinct().ToList();

            List<DateTime> yearDate = new List<DateTime>();
            var january = new DateTime(today.Year, 1, 1);
            var feb = new DateTime(today.Year, 2, 1);
            var mar = new DateTime(today.Year, 3, 1);
            var april = new DateTime(today.Year, 4, 1);
            var may = new DateTime(today.Year, 5, 1);
            var june = new DateTime(today.Year, 6, 1);
            var july = new DateTime(today.Year, 7, 1);
            var aug = new DateTime(today.Year, 8, 1);
            var sep = new DateTime(today.Year, 9, 1);
            var oct = new DateTime(today.Year, 10, 1);
            var nov = new DateTime(today.Year, 11, 1);
            var dec = new DateTime(today.Year, 12, 1);
            yearDate.Add(january);
            yearDate.Add(feb);
            yearDate.Add(mar);
            yearDate.Add(april);
            yearDate.Add(may);
            yearDate.Add(june);
            yearDate.Add(july);
            yearDate.Add(aug);
            yearDate.Add(sep);
            yearDate.Add(oct);
            yearDate.Add(nov);
            yearDate.Add(dec);

            Console.WriteLine(yearDate[2]);
            var startDates = new DateTime(today.Year, today.Month, 1);

            int totals = 0;
            for (int n = 0; n < f; n++)
            {
                for (int j = 0; j < 12; j++)
                {
                    var endDates = yearDate[j].AddMonths(1).AddDays(-1);
                    DateTime temp = ast[n].Total;
                    DateTime latter = ast[n].Total.AddMonths(1);
                    int wel = 140;
                    if (muniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                    {
                        wel = wel + 140;
                    }
                    if (uniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                    {
                        wel = wel + 140;
                    }
                    if (suniqueItemsList.Any(sublist => sublist.Contains(ast[n].Name)))
                    {
                        wel = wel + 70;
                    }
                    while (temp.Year < yearDate[j].Year)
                    {
                        temp = temp.AddYears(1);
                    }

                    if (/*temp >= yearDate[j] &&*/ temp < endDates)
                    {
                        if (temp >= yearDate[j] && temp < endDates)
                        {
                            wel = wel;

                        }
                        else 
                        {
                            if ((agel[n] >= 18))
                            {
                                wel = 0;
                            }
                        }
                    }
                    if (ast[n].Total.Year == today.Year)
                    {
                        if (ast[n].Total.Month <= yearDate[j].Month)
                        {
                            wel = 0;
                        }
                        else if (latter.Month == today.Month)
                        {
                            wel = wel + 140;
                        }

                    }
                    if (ageL[n] >= 18)
                    {
                        wel = 0;
                    }
                    else
                    {
                        totals = totals + wel;
                        

                    }
                }
            }
            string totalls = Convert.ToString(totals);
            MessageBox.Show("The total welfare the Mccave household gained this year is: " + totalls);
        }

        private void Child_Form_8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
