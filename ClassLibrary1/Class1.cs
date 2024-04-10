using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;

namespace ClassLibrary1
{
    public class Class1
    {
        // класс, конвертирующий строку с числом в вещественное число
        public static double Vvod(TextBox input)
        {
            return Convert.ToDouble(input.Text);
        }

        // класс, вычисляющий z с использованием оператора return
        static public double Vichisliz1(double x, double y)
        {
            double z = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x))); 
            return z;
        }

        // класс вычисляющий z  с использованием оператора out
        static public void Vichisliz2(double x, double y, out double z)
        {
            z = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));
        }

        // класс вычисляющий z  с использованием оператора ref
        static public void Vichisliz3(double x, double y, ref double z)
        {
            z = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));
        }

        // класс вычисляющий k  с использованием оператора return
        static public double Vichislik1(double x, double y)
        {
            double k = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x-y);
            return k;
        }

        // класс вычисляющий k  с использованием оператора out
        static public void Vichislik2(double x, double y, out double k)
        {
            k = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);
        }

        // класс вычисляющий k  с использованием оператора ref
        static public void Vichislik3(double x, double y, ref double k)
        {
            k = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);
        }

        // класс, записывающий в TextBox вещественное число 
        static public void Vyvod(TextBox output, double value)
        {
            output.Text = Convert.ToString(value);
        }

        // класс, вычисляющий d в соответствием значения x
        static public double Vichislid(double x, double c, double b, double a)
        {
            double d;
            if (x <  0)
            {
                d = -Math.Pow(-x, 1.0 / 3.0);
                double z = Math.Pow(a, x);
                if (z < d) { d = z; };
            }
            else if (x < 3 && x >= 0)
            {
                d = Math.Cos(1 + (c * Math.Pow(x, 2)) / b);
            }
            else
            {
                d = Math.Pow(a, 1 / 2) + x;
                double z = Math.Tan(x - Math.Pow(c, 2));
                if ( z > d) { d = z; }
                z = Math.Log(Math.Pow(x, 2) + c);
                if ( z < d) { d = z; }
            }
            return d;
        }
        // класс, вычисляющий значение y в соответсвтии с функицей
        static public double VichisliY(double x)
        {
            double y = Math.Pow(x, 3) * Math.Pow(x - 1, 0.5);
            return y;
        }
        // класс, выводящий значения в DataGridView
        public static void VivodDGV(double x, double y, DataGridView DGV)
        {
            DGV.Rows.Add(x.ToString(), y.ToString());
        }
        // класс, выполняющий табуляцию функции VichisliY
        static public double Tab(double x, double b, double h, DataGridView DGV)
        {
            double max = Double.MinValue;
            int n = Convert.ToInt32((b - x) / h + 1);
            for  (int i = 1; i <= n; i++)
            {
                double y = Class1.VichisliY(x);
                Class1.VivodDGV(x, y, DGV);
                x = x + h;
                if (max < y) { max = y; }
            }
            return max;
        }
        // класс, вычисдяющий каждое значение ряда с помощью рекурентной фукнкции и сумму этого ряда
        public static double RowSumm(double x, double e, DataGridView DGV)
        {
            int n = 0;
            double s = 0;
            double a = 1;
            while (Math.Abs(a) >= e)
            {
                s += a;
                Class1.VivodDGV2(n, a, s, DGV);
                a = -a * x * x / (2*n+ 2)/(2*n+3);
                n++;
            }
            Class1.VivodDGV2(n, a, s, DGV);
            return s;
        }
        // клаасс, выводящий 3 значения в DataGridView
        public static void VivodDGV2(int n, double x, double s, DataGridView DGV)
        {
            DGV.Rows.Add(n.ToString(), x.ToString(), s.ToString());
        }
    }
}
