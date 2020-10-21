using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worpengenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(AantalOgen);
            groupBox1.Controls.Add(AantalWorpen);
            groupBox1.Controls.Add(worpennumericUpDown1);
            groupBox1.Controls.Add(ogennumericUpDown2);
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            worpennumericUpDown1.Minimum = 1;
            worpennumericUpDown1.Maximum = 1000;

        }

        private void GooiDobbelsteen_Click(object sender, EventArgs e)
        {

            // AddMethod();
            int aantalWorpen = Convert.ToInt32(worpennumericUpDown1.Value);
            int hogeteDobbelsteen = Convert.ToInt32(ogennumericUpDown2.Value);


             AddRandomToListbox(aantalWorpen,hogeteDobbelsteen) ;  
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           listBox1.Items.Clear();



        }
        /// <summary>
        /// adds an amount of random dice throws to to listbox
        /// </summary>
        /// <param name="amount"></param>
        public void AddRandomToListbox(int amount, int maxDiceValue)
        {
            Random r = new Random();


            // vaker doen
            for (int i = 0; i < amount; i++)
            {
                int resultOfThrow = r.Next(1, maxDiceValue + 1);
                listBox1.Items.Add(resultOfThrow);
            }
            decimal sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listBox1.Items[i]);
            }
            Aantal.Text = Convert.ToString(sum);
        }

        

            
   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ogennumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
            ogennumericUpDown2.Minimum = 2;
            ogennumericUpDown2.Maximum = 100;
            ogennumericUpDown2.Increment = 1;
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox1.Controls.Add(Aantal);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Aantal.Text = "";
        }
    }
}
