using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampere_opdracht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
       
         
            
            
            InitializeComponent();
        }
       
       
        
private void Stroom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Spanning_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Methode();
        }
        public void Methode()
        {
            string stroom = Stroom.Text;
            string spanning = Spanning.Text;
            decimal V = Convert.ToDecimal(stroom);
            decimal A = Convert.ToDecimal(spanning);
            decimal antwoord = V / A;
            string uitkomst = Convert.ToString(antwoord);
            MessageBox.Show(uitkomst, "in ohm");         
            
        }
    }
}
