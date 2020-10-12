using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEuroToDollar1_Click(object sender, EventArgs e)
        {
            //stap 1
            decimal euros;

            euros = Convert.ToDecimal(TBEuro1.Text);
            //stap2
            decimal koers;
            koers = NUMKoers.Value;
            //stap3
            decimal dollars;
            dollars = euros * koers;
            //stap4
            TBDollar1.Text = Convert.ToString (dollars);
        }
    }
}
