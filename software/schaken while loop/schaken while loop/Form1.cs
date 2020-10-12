using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schaken_while_loop
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Teller.Maximum = 6000;
            Teller.Minimum = 0;

        }

        public void tellen()
        {
          
            
           
            for (int i = 0; i <= 64; i = i + 2)
         
            {

                MessageBox.Show(Convert.ToString(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tellen();
        }
    }
}
