using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int boy = Convert.ToInt32(textBox1.Text);

            int dogum_yili = Convert.ToInt32(textBox2.Text);

            int yas = 2021 - dogum_yili;

            double kilo = Convert.ToDouble(textBox3.Text);

            double ideal_kilo = 0;



            if (comboBox1.Text == "Kadın")
            {
                ideal_kilo = (boy - 100 + yas / 10) * 0.8;

                string ideal_kilo2 = ideal_kilo.ToString("0.##");

                textBox4.Text = ideal_kilo2;

                if (kilo == ideal_kilo)
                {
                    label6.Text = "Bravo! İdeal Kilodasınız";
                }

                if (kilo < ideal_kilo)
                {
                    label6.Text = "Zayıfsınız, kilo almalısınız";
                }

                if (kilo > ideal_kilo)
                {
                    label6.Text = "Şismansınız, kilo vermelisiniz";
                }
            }

            if (comboBox1.Text == "Erkek")
            {
                ideal_kilo = (boy - 100 + yas / 10) * 0.9;

                string ideal_kilo2 = ideal_kilo.ToString("0.##");

                textBox4.Text = ideal_kilo2;

                if (kilo == ideal_kilo)
                {
                    label6.Text = "Bravo! İdeal Kilodasınız";
                }

                if (kilo < ideal_kilo)
                {
                    label6.Text = "Zayıfsınız, kilo almalısınız";
                }

                if (kilo > ideal_kilo)
                {
                    label6.Text = "Şismansınız, kilo vermelisiniz";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
