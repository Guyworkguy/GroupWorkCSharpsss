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
    public partial class Child_Form_5 : Form
    {
        public Child_Form_5()
        {
            InitializeComponent();
        }

        private void Child_Form_5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
            Console.WriteLine($"{uniqueItemsList[2]}{suniqueItemsList[0]}");
            int j = suniqueItemsList.Count;
            for (int i = 0; i < j; i++)
            {
                listBox1.Items.Add(suniqueItemsList[i]);
            }
        }

        private void button_triplet_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Clear();
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
                Console.WriteLine($"{uniqueItemsList[2]}{suniqueItemsList[0]}");
                int trip = uniqueItemsList.Count;
                for (int i = 0; i < trip; i++)
                {
                    listBox1.Items.Add(uniqueItemsList[i]);
                }
            }
        }

        private void button_quadruplets_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Clear();
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
                Console.WriteLine($"{uniqueItemsList[2]}{suniqueItemsList[0]}");
                int quad = muniqueItemsList.Count;
                for (int i = 0; i < quad; i++)
                {
                    listBox1.Items.Add(muniqueItemsList[i]);
                }
            }
        }
    }
}
