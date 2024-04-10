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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Переход в главное меню
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        // Выход из программы
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Выполнение задания лабораторной
        private void button12_Click(object sender, EventArgs e)
        {
            int n = Class2.InputInt(textBox1);
            int m = Class2.InputInt(textBox2);
            int y = Class2.InputInt(textBox3);
            int[,] arr = new int[n, m];
            Class2.ArrGen(arr, n, m);
            Class2.OutputArr(arr, n, m, dataGridView1);
            int z = Class2.Lab8(arr, n, m, y);
            Class2.NewArr(arr, n, m, z, dataGridView2);
        }
        // Вызов метода, записывающего исходный и результирующий массивы в Блокнот
        private void button3_Click(object sender, EventArgs e)
        {
            Class2.Bloknot(Class2.arr8, Class2.arr);
        }
        // Вызов метода, записывающего исходный и результирующий массивы в Access
        private void button4_Click(object sender, EventArgs e)
        {
            Class2.Add1();
            Class2.CreateStructDB(Class2.arr8.GetLength(1));
            Class2.AddToBD(Class2.arr8.GetLength(0), Class2.arr8.GetLength(1), Class2.arr8);
            Class2.AddR(Class2.arr.Length, Class2.arr);
        }
        // Вызов метода, записывающего исходный и результирующий массивы в Excel
        private void button5_Click(object sender, EventArgs e)
        {
            Class2.ZapExcel(Class2.arr8.GetLength(0), Class2.arr8.GetLength(1), Class2.arr8, Class2.arr.Length);
        }
        // Вызов метода, выполняющего макрос в Excel
        private void button6_Click(object sender, EventArgs e)
        {
            Class2.MakrosExcel();
        }
        // Вызов метода, записывающего исходный и результирующий массивы в Word
        private void button7_Click(object sender, EventArgs e)
        {
            Class2.ZV(Class2.arr8.GetLength(0), Class2.arr8.GetLength(1), Class2.arr.Length);
        }
    }
}
