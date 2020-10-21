using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_opgaven_herhalingsstructuren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
         
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            method1();
        }



        public void method1()
        {
            string tekst = invoer.Text;
            int tekst2 = Convert.ToInt32(tekst);
            //int nummer2 = Convert.ToInt32(nummer);
            //int invoer2 = Convert.ToInt32(invoer.Text);
            for (int i = 0; i < 10 + 1; i++)
            {
                Decimal tafel = (Convert.ToDecimal(i * tekst2));
                Lijst.Items.Add(tafel);
                
                if (tafel == tafel % 3)
                {
                    Uitkomst.Text ="deelbaar door 3";
                }

            }
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Lijst.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
