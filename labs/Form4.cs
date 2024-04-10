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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        // выход из программы
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // переход в главное меню
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // кнопка, вызывающая табулирование функции
        private void button4_Click(object sender, EventArgs e)
        {
            // проверка на заполнение полей дейтвительными числами
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = double.TryParse(textBox1.Text, out double result);
            bool ch2 = double.TryParse(textBox1.Text, out result);
            bool ch3 = double.TryParse(textBox1.Text, out result);
            if (ch1 == false || ch2 == false || ch3 == false)
            {
                MessageBox.Show("Введите действительное число", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double a = Class1.Vvod(textBox4);
            double b = Class1.Vvod(textBox1);
            double h = Class1.Vvod(textBox2);
            dataGridView2.ColumnCount = 2;
            dataGridView2.Rows.Add("Значение х", "Значение y");
            double mmax = b;
            double min = a;
            if (a>b) { mmax = a; min = b; textBox4.Text = Convert.ToString(b); textBox1.Text = Convert.ToString(a); }
            double max = Class1.Tab(min, mmax, h, dataGridView2);
            Class1.Vyvod(textBox3, max);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
