using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox2.Text == "inch")
            {
                label5.Text = "inch";

            }

            if (comboBox2.Text == "foot")
            {
                label5.Text = "foot";
            }

            if (comboBox2.Text == "yard")
            {
                label5.Text = "yard";
            }

            if (comboBox2.Text == "kara mili")
            {
                label5.Text = "kara mili";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double metre = Convert.ToDouble(textBox1.Text);

            if (label5.Text == "inch")
            {
                double inch = metre * 39.3701;
                string sonuc = inch.ToString("0.##");
                textBox2.Text = sonuc;
            }

            if (label5.Text == "foot")
            {
                double foot = metre * 3.28084;
                string sonuc = foot.ToString("0.##");
                textBox2.Text = sonuc;
            }

            if (label5.Text == "yard")
            {
                double yard = metre * 1.09361;
                string sonuc = yard.ToString("0.##");
                textBox2.Text = sonuc;
            }

            if (label5.Text == "kara mili")
            {
                double kara_mili = metre * 0.00062137;
                string sonuc = kara_mili.ToString();
                textBox2.Text = sonuc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Kw")
            {
                label7.Text = "Kw";
            }

            if (comboBox4.Text == "Kcal/s")
            {
                label7.Text = "Kcal/s";
            }

            if (comboBox4.Text == "PS")
            {
                label7.Text = "PS";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kgf = Convert.ToDouble(textBox3.Text);

            if (label7.Text == "Kw")
            {
                double kw = kgf * 0.0098;
                string sonuc = kw.ToString();
                textBox4.Text = sonuc;
            }

            if (label7.Text == "Kcal/s")
            {
                double kcal = kgf * 0.00234;
                string sonuc = kcal.ToString();
                textBox4.Text = sonuc;
            }

            if (label7.Text == "PS")
            {
                double ps = kgf * 0.0133;
                string sonuc = ps.ToString();
                textBox4.Text = sonuc;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "psi")
            {
                label9.Text = "psi";
            }

            if (comboBox6.Text == "bar")
            {
                label9.Text = "bar";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double atm = Convert.ToDouble(textBox5.Text);

            if (label9.Text == "psi")
            {
                double psi = atm * 14.65;
                string sonuc = psi.ToString("0.##");
                textBox6.Text = sonuc;
            }

            if (label9.Text == "bar")
            {
                double bar = atm * 1.01;
                string sonuc = bar.ToString("0.##");
                textBox6.Text = sonuc;
            }
        }
    }
}
