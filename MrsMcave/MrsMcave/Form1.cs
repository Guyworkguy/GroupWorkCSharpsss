using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrsMcave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileCreator_Click(object sender, EventArgs e)
        {
            string path =Environment.CurrentDirectory + "/" + "mccaveFamily.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
                MessageBox.Show("Mrs.Mccave has found her family!");
            }
            else
            {
                MessageBox.Show("Let's help Mccave with her family problems!");
            }
           
        }
   
    }
}
