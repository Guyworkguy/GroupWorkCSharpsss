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
    public partial class Child_Form_4 : Form
    {
        public Child_Form_4()
        {
            InitializeComponent();
        }

        private void Child_Form_4_Load(object sender, EventArgs e)
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
            List<string> words = new List<string>();
            words = new List<string>();
           // words.AddRange(File.ReadAllLines(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/words.txt"));

            foreach (var Child in Dave)
            {

                string ma = (Child.nName);
                words.Add(ma);
                Console.WriteLine(ma);
            }
            foreach (string str in words)
            {
                listBox1.Items.Add(str);
            }

            words = words.OrderBy(x => x).ToList();

           
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
            List<string> words = new List<string>();
            words = new List<string>();
            // words.AddRange(File.ReadAllLines(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/words.txt"));

            foreach (var Child in Dave)
            {

                string ma = (Child.nName);
                words.Add(ma);
                Console.WriteLine(ma);
            }
           

            words = words.OrderBy(x => x).ToList();

            foreach (string str in words)
            {
                listBox2.Items.Add(str);
            }
        }
    }
    }

