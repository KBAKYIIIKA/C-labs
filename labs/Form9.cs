using ClassLibrary1;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Class2.AddExcel(Class2.arr, Class2.rarr);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Class2.AddWord(Class2.arr, Class2.rarr);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Class2.Add1();
            Class2.Add_struct1();
            Class2.Add_zapi(Class2.arr, Class2.rarr, Class2.arr.Length, Class2.lrarr);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Class2.Makros();
        }
    }
}
