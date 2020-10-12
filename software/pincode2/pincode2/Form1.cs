using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pincode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Pin_Click(object sender, EventArgs e)
        {

            string username = Gebruikersnaam.Text;
            string password = Wachtwoord.Text;

            if ((this.Wachtwoord.Text == "EE") && (this.Gebruikersnaam.Text == "EE"))
            {
                MessageBox.Show("toegestaan_pincode_is_5555");
            }

            if ((this.Wachtwoord.Text == "") && (this.Gebruikersnaam.Text == ""))
            {
                MessageBox.Show("niet toegestaan");
            }
        }
    }
}
