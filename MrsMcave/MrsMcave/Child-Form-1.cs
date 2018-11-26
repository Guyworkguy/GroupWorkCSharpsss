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
    public partial class Child_Form_1 : Form
    {
        public Child_Form_1()
        {
            InitializeComponent();
        }

        private void Child_Form_1_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
            using (StreamReader writetext = new StreamReader(path))
            {
                textBox1.Text = File.ReadAllText(path);
            }
        }
    }
}
