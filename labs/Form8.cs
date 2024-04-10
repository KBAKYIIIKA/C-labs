using ClassLibrary2;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // проверка на заполнение полей целыми числами
            if (textBox1.Text == "" || textBox4.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool ch1 = int.TryParse(textBox1.Text, out int result);
            bool ch2 = int.TryParse(textBox1.Text, out result);
            if (ch1 == false || ch2 == false)
            {
                MessageBox.Show("Введите целое число", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int length = Class2.InputInt(textBox4);
            int[] arr = new int[length];
            int A = Class2.InputInt(textBox1);
            int B = Class2.InputInt(textBox2);
            int max = B;
            int min = A;
            if (A > B) { max = A; min = B; textBox1.Text = Convert.ToString(B); textBox2.Text = Convert.ToString(A); }
            Class2.Enter_mas(arr, length, min, max);
            Class2.Output_mas(arr, length, dataGridView1);
            Class2.Change_mas(arr, length);
            Class2.Output_mas(arr, length, dataGridView2);
        }
        // выход из программы
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // выход в главное меню
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
