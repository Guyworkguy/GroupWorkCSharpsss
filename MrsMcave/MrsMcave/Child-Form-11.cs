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
    public partial class Child_Form_11 : Form
    {
        public Child_Form_11()
        {
            InitializeComponent();
        }

        private void Child_Form_11_Load(object sender, EventArgs e)
        {


            /* chartMilestone.Series["Milestone"].Points.AddXY("Preschool", 2);
             chartMilestone.Series["Milestone"].Points.AddXY("Primary school", 13);
             chartMilestone.Series["Milestone"].Points.AddXY("Secondary school", 8);
             chartMilestone.Series["Milestone"].Points.AddXY("College", 3);
             chartMilestone.Series["Milestone"].Points.AddXY("Finished", 2);*/


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

            DateTime t = new DateTime(2018, 7, 10);
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
                if (today.Month < jo[i].Month)
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
            int trip = uniqueItemsList.Count;
            int twin = muniqueItemsList.Count;
            int quad = suniqueItemsList.Count;

           
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
           
            int jani = 0, febi = 0, mari = 0, apri = 0, mayi = 0, junei = 0, julyi = 0, augi = 0, sepi = 0, octi = 0, novi = 0, deci = 0;

            for (int i = 0; i < f; i++)
            {
                
                    if (jo[i].Month == january.Month)
                    {
                        jani++;
                    }
                    if (jo[i].Month == feb.Month)
                    {
                        febi++;
                    }
                    if (jo[i].Month == mar.Month)
                    {
                        mari++;
                    }
                    if (jo[i].Month == april.Month)
                    {
                        apri++;
                    }
                    if (jo[i].Month == may.Month)
                    {
                        mayi++;
                    }
                    if (jo[i].Month == june.Month)
                    {
                        junei++;
                    }
                    if (jo[i].Month == july.Month)
                    {
                        julyi++;
                    }
                    if (jo[i].Month == aug.Month)
                    {
                        augi++;
                    }
                    if (jo[i].Month == sep.Month)
                    {
                        sepi++;
                    }
                    if (jo[i].Month == oct.Month)
                    {
                        octi++;
                    }
                    if (jo[i].Month == nov.Month)
                    {
                        novi++;
                    }
                    if (jo[i].Month == dec.Month)
                    {
                        deci++;
                    }

                
            }

            chartMilestone.Series["Milestone"].Points.Add(preschool);
            chartMilestone.Series["Milestone"].Points[0].Color = Color.Red;
            chartMilestone.Series["Milestone"].Points[0].AxisLabel = "Preschool";
            chartMilestone.Series["Milestone"].Points[0].LegendText = "Preschool";
            //chartMilestone.Series["Milestone"].Points[0].Label = "2";

            //

            chartMilestone.Series["Milestone"].Points.Add(primary);
            chartMilestone.Series["Milestone"].Points[1].Color = Color.Blue;
            chartMilestone.Series["Milestone"].Points[1].AxisLabel = "Primary School";
            chartMilestone.Series["Milestone"].Points[1].LegendText = "Primary School";
           // chartMilestone.Series["Milestone"].Points[1].Label = "13";

            //

            chartMilestone.Series["Milestone"].Points.Add(secondary);
            chartMilestone.Series["Milestone"].Points[2].Color = Color.Green;
            chartMilestone.Series["Milestone"].Points[2].AxisLabel = "Secondary school";
            chartMilestone.Series["Milestone"].Points[2].LegendText = "Secondary school";
         //   chartMilestone.Series["Milestone"].Points[2].Label = "8";

            //

            chartMilestone.Series["Milestone"].Points.Add(college);
            chartMilestone.Series["Milestone"].Points[3].Color = Color.Yellow;
            chartMilestone.Series["Milestone"].Points[3].AxisLabel = "College";
            chartMilestone.Series["Milestone"].Points[3].LegendText = "College";
           // chartMilestone.Series["Milestone"].Points[3].Label = "3";

            //

            chartMilestone.Series["Milestone"].Points.Add(finished);
            chartMilestone.Series["Milestone"].Points[4].Color = Color.Orange;
            chartMilestone.Series["Milestone"].Points[4].AxisLabel = "Finished";
            chartMilestone.Series["Milestone"].Points[4].LegendText = "Finished";
            //chartMilestone.Series["Milestone"].Points[4].Label = "2";

            // twin chart // 
         
            chartTwin.Series["twinchart"].Points.Add(twin);
            chartTwin.Series["twinchart"].Points[0].Color = Color.Crimson;
            chartTwin.Series["twinchart"].Points[0].AxisLabel = "Twins";
            chartTwin.Series["twinchart"].Points[0].LegendText = "Twins";
            //chartTwin.Series["twinchart"].Points[0].Label = "4";


            //

            chartTwin.Series["twinchart"].Points.Add(trip);
            chartTwin.Series["twinchart"].Points[1].Color = Color.Blue;
            chartTwin.Series["twinchart"].Points[1].AxisLabel = "Triplets";
            chartTwin.Series["twinchart"].Points[1].LegendText = "Triplets";
            //chartTwin.Series["twinchart"].Points[1].Label = "3";

            //

            chartTwin.Series["twinchart"].Points.Add(quad);
            chartTwin.Series["twinchart"].Points[2].Color = Color.Yellow;
            chartTwin.Series["twinchart"].Points[2].AxisLabel = "Quadruplets";
            chartTwin.Series["twinchart"].Points[2].LegendText = "Quadruplets";
            //chartTwin.Series["twinchart"].Points[2].Label = "4";

            //


            // month // 



            chartmonth.Series["monthchart"].Points.Add(jani);
            chartmonth.Series["monthchart"].Points[0].Color = Color.LightBlue;
            chartmonth.Series["monthchart"].Points[0].AxisLabel = "January";
            chartmonth.Series["monthchart"].Points[0].LegendText = "January";
            //chartmonth.Series["monthchart"].Points[0].Label = "1";


            //


            chartmonth.Series["monthchart"].Points.Add(febi);
            chartmonth.Series["monthchart"].Points[1].Color = Color.Blue;
            chartmonth.Series["monthchart"].Points[1].AxisLabel = "Febuary";
            chartmonth.Series["monthchart"].Points[1].LegendText = "Febuary";
            //chartmonth.Series["monthchart"].Points[1].Label = "1";

            //

            chartmonth.Series["monthchart"].Points.Add(mari);
            chartmonth.Series["monthchart"].Points[2].Color = Color.Green;
            chartmonth.Series["monthchart"].Points[2].AxisLabel = "March";
            chartmonth.Series["monthchart"].Points[2].LegendText = "March";
            //chartmonth.Series["monthchart"].Points[2].Label = "8";

            //

            chartmonth.Series["monthchart"].Points.Add(apri);
            chartmonth.Series["monthchart"].Points[3].Color = Color.LimeGreen;
            chartmonth.Series["monthchart"].Points[3].AxisLabel = "April";
            chartmonth.Series["monthchart"].Points[3].LegendText = "April";
//            chartmonth.Series["monthchart"].Points[3].Label = "3";


            //

            chartmonth.Series["monthchart"].Points.Add(mayi);
            chartmonth.Series["monthchart"].Points[4].Color = Color.Turquoise;
            chartmonth.Series["monthchart"].Points[4].AxisLabel = "May";
            chartmonth.Series["monthchart"].Points[4].LegendText = "May";
  //          chartmonth.Series["monthchart"].Points[4].Label = "2";

            //

            chartmonth.Series["monthchart"].Points.Add(junei);
            chartmonth.Series["monthchart"].Points[5].Color = Color.LightPink;
            chartmonth.Series["monthchart"].Points[5].AxisLabel = "June";
            chartmonth.Series["monthchart"].Points[5].LegendText = "June";
    //        chartmonth.Series["monthchart"].Points[5].Label = "4";


            //

            chartmonth.Series["monthchart"].Points.Add(julyi);
            chartmonth.Series["monthchart"].Points[6].Color = Color.Pink;
            chartmonth.Series["monthchart"].Points[6].AxisLabel = "July";
            chartmonth.Series["monthchart"].Points[6].LegendText = "July";
      //      chartmonth.Series["monthchart"].Points[6].Label = "0";

            //

            chartmonth.Series["monthchart"].Points.Add(augi);
            chartmonth.Series["monthchart"].Points[7].Color = Color.HotPink;
            chartmonth.Series["monthchart"].Points[7].AxisLabel = "August";
            chartmonth.Series["monthchart"].Points[7].LegendText = "August";
        //    chartmonth.Series["monthchart"].Points[7].Label = "1";

            //

            chartmonth.Series["monthchart"].Points.Add(sepi);
            chartmonth.Series["monthchart"].Points[8].Color = Color.Yellow;
            chartmonth.Series["monthchart"].Points[8].AxisLabel = "September";
            chartmonth.Series["monthchart"].Points[8].LegendText = "September";
          //  chartmonth.Series["monthchart"].Points[8].Label = "4";


            //

            chartmonth.Series["monthchart"].Points.Add(octi);
            chartmonth.Series["monthchart"].Points[9].Color = Color.Orange;
            chartmonth.Series["monthchart"].Points[9].AxisLabel = "October";
            chartmonth.Series["monthchart"].Points[9].LegendText = "October";
            //chartmonth.Series["monthchart"].Points[9].Label = "0";

            //

            chartmonth.Series["monthchart"].Points.Add(novi);
            chartmonth.Series["monthchart"].Points[10].Color = Color.DarkOrange;
            chartmonth.Series["monthchart"].Points[10].AxisLabel = "November";
            chartmonth.Series["monthchart"].Points[10].LegendText = "November";
            //chartmonth.Series["monthchart"].Points[10].Label = "4";

            //

            chartmonth.Series["monthchart"].Points.Add(deci);
            chartmonth.Series["monthchart"].Points[11].Color = Color.Silver;
            chartmonth.Series["monthchart"].Points[11].AxisLabel = "December";
            chartmonth.Series["monthchart"].Points[11].LegendText = "December";
            //chartmonth.Series["monthchart"].Points[11].Label = "0";

            //


        }

        private void chartTwin_Click(object sender, EventArgs e)
        {

        }

        private void chartMilestone_Click(object sender, EventArgs e)
        {

        }
    }
}
