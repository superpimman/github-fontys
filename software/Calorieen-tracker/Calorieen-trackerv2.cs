using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latenight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMan_CheckedChanged(object sender, EventArgs e)
        {
            
            
           //man vrouw waarde geven en uitkomst leeg laten
            Decimal man = 2500;
            Decimal vrouw = 2000;
            Decimal uitkomst ;
            
            // kijken of man of vrouw word aangevinkt
            bool isChecked = BtnMan.Checked;
            if (isChecked)
                uitkomst = man;
            else
                uitkomst = vrouw;
            
            // berekening -10 %
            Decimal uitkomst1 = uitkomst / 100 * 90;


            // variablen voor keuze actief of niet actief  
            Decimal uitkomst2 = uitkomst1;

            Decimal uitkomst3 = uitkomst;
            
            if (LsNietActief.Checked == true)
            {
                uitkomst = uitkomst2;
            }

            if (LsActief.Checked == true)
            {
                uitkomst = uitkomst3;
            }
            Decimal antwoord ;
            // aan maken keuzes en leeftijd textbox
            string userinput = LeeftijdBox.Text;
            
            Decimal totaal1 = uitkomst;
            Decimal totaal2 = uitkomst - 200;
            int userinput2;
            // convert textbox voor int
            int.TryParse(userinput, out userinput2);
            
            //als input 50 of hoger is gaat er 200 af
            if (userinput2 >= 50)
            {
               antwoord = totaal2;
            }
            
            else
            {
               antwoord = totaal1 ;
            }
        }

         public void Bereken_Click(object sender, EventArgs e)
        {
            Bereken.Click += new EventHandler(Bereken_Click);
            this.Controls.Add(Bereken);

            {
                MessageBox.Show(Convert.ToString(antwoord));
            }

        }
        

        
    }
    }


