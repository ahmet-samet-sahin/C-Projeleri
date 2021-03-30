using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                textBox3.Text = Convert.ToString(sayi1 + sayi2);            
            
            
            }

            if (radioButton2.Checked) 
            {
                textBox3.Text = Convert.ToString(sayi1 - sayi2);
            
            }

            if (radioButton3.Checked) 
            {
                textBox3.Text = Convert.ToString(sayi1 * sayi2);
            
            }

            if (radioButton4.Checked) 
            {
                textBox3.Text = Convert.ToString(sayi1 / sayi2);
            }
             
            if (radioButton5.Checked) 
            {
                textBox3.Text = Convert.ToString(Math.Pow(sayi1,sayi2));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
