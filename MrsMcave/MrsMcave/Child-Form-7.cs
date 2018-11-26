using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrsMcave
{
    public partial class Child_Form_7 : Form
    {
        string[] FistName = { "Jim", "Simon", "Adam", "Cathal", "Conor", "Jack", "Thomas", "Cian", "Odhran", "Sean", "Pual", "Stephen" };
        Random rand = new Random();
        public Child_Form_7()
        {
            InitializeComponent();
        }

        private void txtbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            int indexFirstName = rand.Next(FistName.Length);
            

            this.txtbox_FirstName.Text = FistName[indexFirstName];
            
        }
    }
}
