using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_number_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nummer;
        private void Form1_Load(object sender, EventArgs e)
        {
         

            Random generator = new Random();
            nummer = generator.Next(1, 100);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(textBox1.Text);
            if (guess == nummer)
            {
                textBox2.Text = "juist";
            }
            if (guess > nummer)
            {
                textBox2.Text = "te hoog";
            }
            if (guess < nummer)
            {
                textBox2.Text = "te laag";
            }
        }
    }
}
