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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // выход из программы
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // переход в глваное меню
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // кнопка, вызывающая разложение ряда с помощью рекурентной формулы.
        // также вычисляет значение ряда с помощью встроенной математической функции
        private void button4_Click(object sender, EventArgs e)
        {
            // проверка на ввод действительных чисел
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = double.TryParse(textBox1.Text, out double result);
            bool ch2 = double.TryParse(textBox1.Text, out result);
            if (ch1 == false || ch2 == false)
            {
                MessageBox.Show("Введите действительное число", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double x = Class1.Vvod(textBox4);
            if (x == 0)
            {
                MessageBox.Show("Введите x не равное 0", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "";
                return;
            }
            double accuracy = Class1.Vvod(textBox1);
            dataGridView2.ColumnCount = 3;
            dataGridView2.Rows.Add("Число итераций", "Элемент", "Текущая сумма");
            double s = Class1.RowSumm(x, accuracy, dataGridView2);
            Class1.Vyvod(textBox2, s);
            Class1.Vyvod(textBox3, Math.Sin(x)/x);
        }
    }
}
