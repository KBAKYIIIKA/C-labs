using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratornie_raboti
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // выход из программы
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // переход в главное меню
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        // кнопка, вызывающая методы для вычисления d
        private void button4_Click(object sender, EventArgs e)
        {
            // отдельная проверка на введение дейсвтительного числа x
            double a = 0; double b = 0; double c = 0; double d;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите x", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = double.TryParse(textBox2.Text, out double result);
            if (ch1 == false)
            {
                MessageBox.Show("Введите действительное число", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // проверки на введение необходимых для вычисления, значений в соответствии с введённым х
            double x = Class1.Vvod(textBox2);
            if ((x >=0 & x <3) & (textBox1.Text == "" || textBox3.Text == ""))
            {
                MessageBox.Show("Введите необходимые переменные", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((x < 0 ) & (textBox4.Text == ""))
            {
                MessageBox.Show("Введите необходимые переменные", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((x >= 3) & (textBox1.Text == "" || textBox4.Text == ""))
            {
                MessageBox.Show("Введите необходимые переменные", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // проверка на ввод дейсвтительных значений в необходимые переменные в соответсвтии с введённым х
            bool ch2 = double.TryParse(textBox4.Text, out result);
            bool ch3 = double.TryParse(textBox3.Text, out result);
            bool ch4 = double.TryParse(textBox1.Text, out result);
            if ((x >= 0) & (x < 3))
            {
                if (ch3 == false || ch4 == false)
                {
                    MessageBox.Show("Введите действительные числа", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                b = Class1.Vvod(textBox3);
                c = Class1.Vvod(textBox1);
                d = Class1.Vichislid(x, c, b, a);
                Class1.Vyvod(textBox8, d);
            }
            if (x<0)
            {
                if (ch2 == false)
                {
                    MessageBox.Show("Введите действительные числа", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                a = Class1.Vvod(textBox4);
                d = Class1.Vichislid(x, c, b, a);
                Class1.Vyvod(textBox8, d);

            }
            if (x >= 3)
            {
                if (ch2 == false || ch4 == false)
                {
                    MessageBox.Show("Введите действительные числа", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                a = Class1.Vvod(textBox4);
                c = Class1.Vvod(textBox1);
                d = Class1.Vichislid(x, c, b, a);
                Class1.Vyvod(textBox8, d);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
