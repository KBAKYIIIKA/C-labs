using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace laboratornie_raboti
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // закрытие программы
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // переход в главное меню
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        // кнопка, вызывающая методы по вычислению z тремя способами
        private void button4_Click(object sender, EventArgs e)
        {
            // проверки на заполнение полей числами
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = double.TryParse(textBox1.Text, out double result);
            bool ch2 = double.TryParse(textBox2.Text, out result);
            if (ch1 == false || ch2 == false)
            {
                MessageBox.Show("Введите действительные числа", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double x = Class1.Vvod(textBox1);
            double y = Class1.Vvod(textBox2);
            double z = Class1.Vichisliz1(x, y);
            Class1.Vyvod(textBox3, z);
            Class1.Vichisliz2(x, y, out double z2);
            Class1.Vyvod(textBox6, z2);
            double d = 0;
            Class1.Vichisliz3(x, y, ref d);
            Class1.Vyvod(textBox8, d);
        }
        // кнопка, вызывающая методы по вычислению k тремя способами
        private void button5_Click(object sender, EventArgs e)
        {
            // проверки на заполнение полей действительными числами
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = double.TryParse(textBox1.Text, out double result);
            bool ch2 = double.TryParse(textBox2.Text, out result);
            if (ch1 == false || ch2 == false)
            {
                MessageBox.Show("Введите действительные числа", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double x = Class1.Vvod(textBox1);
            double y = Class1.Vvod(textBox2);
            double k = Class1.Vichislik1(x, y);
            Class1.Vyvod(textBox4, k);
            Class1.Vichislik2(x, y, out double k2);
            Class1.Vyvod(textBox5, k2);
            double f = 0;
            Class1.Vichislik3(x, y, ref f);
            Class1.Vyvod(textBox7, f);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
