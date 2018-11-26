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
using System.Text.RegularExpressions;

namespace MrsMcave
{
    public partial class Child_Form_6 : Form
    {
        public Child_Form_6()
        {
            InitializeComponent();
        }

        private void Child_Form_6_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                DateTime datee = Convert.ToDateTime(wDate.Text);
                DateTime today = DateTime.Today;
                
                if (regexItem.IsMatch(txtText.Text) && regexItem.IsMatch(wLike.Text) && DateTime.TryParse(wDate.Text, out datee)&&datee<=today)
                {
                    string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
                    using (StreamWriter writetext = new StreamWriter(path, true))
                    {
                        writetext.WriteLine(txtText.Text + "-" + wDate.Text + "-" + wLike.Text);
                        MessageBox.Show("The child has been added to the family");
                    }
                }
                else
                {
                    MessageBox.Show("Please re-enter into the fields without using special characters eg.#@-&% etc or if your date is greater than today change it!");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date.(dd/mm/yyyy)");
            }  


           
        }
    }
}
