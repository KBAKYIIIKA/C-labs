using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;
using ClassLibrary1;
using Microsoft.VisualBasic;


namespace laboratornie_raboti
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и удаления максимального значения с последующим выводом результирующего массива
        private void button2_Click(object sender, EventArgs e)
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
            Class2.DelMax(arr, length, dataGridView2);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и удаления значения с выбранным индексом с последующим выводом результирующего массива
        private void button3_Click(object sender, EventArgs e)
        {
            // проверка на заполнение полей целыми чсилами
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
            string mess = "Введите номер удаляемого числа";
            int pozition = Class2.InputBox(mess);
            Class2.Del(arr, length, dataGridView2, pozition);
        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и проверкой на монотонномть (монотонное убывание)
        private void button5_Click(object sender, EventArgs e)
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
            dataGridView2.ColumnCount = 0;
            int length = Class2.InputInt(textBox4);
            int[] arr = new int[length];
            int A = Class2.InputInt(textBox1);
            int B = Class2.InputInt(textBox2);
            int max = B;
            int min = A;
            if (A > B) { max = A; min = B; textBox1.Text = Convert.ToString(B); textBox2.Text = Convert.ToString(A); }
            Class2.Enter_mas(arr, length, min, max);
            Class2.Output_mas(arr, length, dataGridView1);
            string Mono = Class2.Mono(arr, length, dataGridView2);
            MessageBox.Show(Mono, "Монотонность", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и нахождения первого нечётного элемента в массиве
        private void button6_Click(object sender, EventArgs e)
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
            dataGridView2.ColumnCount = 0;
            int length = Class2.InputInt(textBox4);
            int[] arr = new int[length];
            int A = Class2.InputInt(textBox1);
            int B = Class2.InputInt(textBox2);
            int max = B;
            int min = A;
            if (A > B) { max = A; min = B; textBox1.Text = Convert.ToString(B); textBox2.Text = Convert.ToString(A); }
            Class2.Enter_mas(arr, length, min, max);
            Class2.Output_mas(arr, length, dataGridView1);
            Class2.Nech(arr, length);
        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и нахождения первого чётного элемента
        private void button7_Click(object sender, EventArgs e)
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
            dataGridView2.ColumnCount = 0;
            int length = Class2.InputInt(textBox4);
            int[] arr = new int[length];
            int A = Class2.InputInt(textBox1);
            int B = Class2.InputInt(textBox2);
            int max = B;
            int min = A;
            if (A > B) { max = A; min = B; textBox1.Text = Convert.ToString(B); textBox2.Text = Convert.ToString(A); }
            Class2.Enter_mas(arr, length, min, max);
            Class2.Output_mas(arr, length, dataGridView1);
            Class2.Сhet(arr, length);
        }
        // кнопка, вызывающая методы по заполнению массива, его вывода
        // и сортиовки простым выбором с последующим выводом результирующего массива
        private void button8_Click(object sender, EventArgs e)
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
            Class2.Sort(arr, length);
            Class2.Output_mas(arr, length, dataGridView2);
        }
    }
}

