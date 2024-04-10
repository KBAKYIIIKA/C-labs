using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Excel = Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Access;
using ADOX;
using System.Data.OleDb;
using System.Linq.Expressions;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace ClassLibrary2
{

    public class Class2
    {
        public static int[,] arr8;
        public static int[] arr;
        public static int[] rarr;
        public static int lrarr = 0;
        private static string NameExcel = @"C:\Users\arbaa\OneDrive\Рабочий стол\%№;№%;№%\Mk.xlsm";
        private static string NameExcel1 = @"C:\Users\arbaa\OneDrive\Рабочий стол\%№;№%;№%\lab8.xlsm";
        public static int[] Mas(int length, int[] mas)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = mas[i];
            }
            return arr;
        }
        public static int[,] Mas8(int[,] mas, int n, int m)
        {
            int[,] arr8 = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr8[i, j] = mas[i, j];
                }    
            }
            return arr8;
        }
        // класс, конвертирующий текстовое число в целочисленное
        public static int InputInt(TextBox input)
        {
            return Convert.ToInt32(input.Text);
        }
        // класс, заполняющий массив случайными значениями
        public static void Enter_mas(int[] mas, int length, int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                mas[i] = rnd.Next(a, b + 1);
            }
            arr = Class2.Mas(length, mas);
        }
        // класс, выводящий массив в таблицу DataGridView
        public static void Output_mas(int[] mas, int length, DataGridView grid)
        {
            grid.ColumnCount = length;
            grid.RowCount = 2;
            for (int i = 0; i < length; i++)
            {
                grid.Rows[0].Cells[i].Value = "[" + i + "]";
                grid.Rows[1].Cells[i].Value = mas[i];
            }
        }
        // класс, изменяющий исходный массив в соответствии с заданием
        public static void Change_mas(int[] mas, int length)
        {
            int max_nech = int.MinValue;
            int max_ch = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (mas[i] % 2 == 0 & mas[i] > max_ch) { max_ch = mas[i]; }
                else if (((mas[i] % 2 == 1) | (mas[i] % 2 == -1)) & (mas[i] > max_nech)) { max_nech = mas[i]; }
            }
            if (max_nech > max_ch)
            {
                for (int i = 0; i < length; i++) { if (mas[i] % 2 == 0) { mas[i] = 0; } }

            }
            else
                for (int i = 0; i < length; i++)
                {
                    if ((mas[i] % 2 == -1) | (mas[i] % 2 == 1)) { mas[i] = 0; }
                }
        }
        // класс, вызывающий окно ввода, в которое пользователь вводит целое число
        public static int InputBox(string mess)
        {
            int chislo = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(mess, "Ввод", "", -1, -1));
            return chislo;
        }
        // класс, удаляющий максимальный элемент в массиве
        public static void DelMax(int[] mas, int length, DataGridView DGV)
        {
            int k = 0;
            for (int i = 1; i < length; i++)
            {
                if (mas[i] > mas[k])
                {
                    k = i;
                }
            }
            for (int i = k; i < length - 1; i++)
            {
                mas[i] = mas[i + 1];
            }
            length = length - 1;
            Class2.Output_mas(mas, length, DGV);
            rarr = Class2.Mas(length, mas);
            lrarr = rarr.Length;
        }
        // класс, удаляющий число с выбранным индексом
        public static void Del(int[] mas, int length, DataGridView DGV, int k)
        {
            for (int i = 1; i < length; i++)
            {
                if (mas[i] == k)
                {
                    k = i;
                }
            }
            for (int i = k; i < length - 1; i++)
            {
                mas[i] = mas[i + 1];
            }
            length = length - 1;
            Class2.Output_mas(mas, length, DGV);
            rarr = Class2.Mas(length, mas);
            lrarr = rarr.Length;
        }
        // класс, проверяющий массив на монотонность (на монотонное убывание)
        public static string Mono(int[] mas, int length, DataGridView DGV)
        {
            rarr = Class2.Mas(0, mas);
            int i = 0;
            int Flag = 1;
            while (i < length - 1 && Flag == 1)
            {
                if (mas[i] >= mas[i + 1]) { i = i + 1; }
                else { Flag = 0; }
            }
            if (Flag == 1) { return "Да"; }
            else { return "Нет"; }
        }
        // класс, находящий первое нечётное число в массиве
        public static void Nech(int[] mas, int length)
        {
            rarr = Class2.Mas(0, mas);
            int i = 0;
            int Flag = 1;
            while (i < length && Flag == 1)
            {
                if (mas[i] % 2 == 0) { i = i + 1; }
                else { Flag = 0; MessageBox.Show(Convert.ToString(mas[i]), "Первый нечётный", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        // класс, находящий первое чётное число в массиве
        public static void Сhet(int[] mas, int length)
        {
            rarr = Class2.Mas(0, mas);
            int i = 0;
            int Flag = 1;
            while (i < length && Flag == 1)
            {
                if ((mas[i] % 2 == 1) | (mas[i] % 2 == -1)) { i = i + 1; }
                else { Flag = 0; MessageBox.Show(Convert.ToString(mas[i]), "Первый чётный", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        // класс,выполняющий сортировку массива простым выбором
        public static void Sort(int[] mas, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (mas[j] < mas[k])
                    {
                        k = j;
                    }
                }
                int x = mas[k];
                mas[k] = mas[i];
                mas[i] = x;
            }
            rarr = Class2.Mas(length, mas);
            lrarr = rarr.Length;
        }
        // Запись исходного и результирующего массива в Excel
        public static void AddExcel(int[] mas, int[] arr)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(NameExcel, 0, false, 5, "", "",
                false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet workSheet;
            workSheet = (Worksheet)ObjWorkBook.Worksheets.get_Item(1);
            workSheet.Name = "Массивы";
            workSheet.Cells[1, 1] = "Массив исходный";
            for (int i = 0; i < mas.Length; i++)
            {
                int q = i + 1;
                workSheet.Cells[2, i + 1] = "[" + q + "]";
                workSheet.Cells[3, i + 1] = mas[i];
            }
            workSheet.Cells[5, 1] = "Массив результирующий";
            for (int i = 0; i < arr.Length; i++)
            {
                int q = i + 1;
                workSheet.Cells[6, i + 1] = "[" + q + "]";
                workSheet.Cells[7, i + 1] = arr[i];
            }
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }
        public static void Makros()
        {
            Microsoft.Office.Interop.Excel.Application app = new
Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbooks books = app.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook book = null;
            book = books.Open(@"C:\Users\arbaa\OneDrive\Рабочий стол\%№;№%;№%\Mk.xlsm");
            app.Run((object)"tttt");
            app.ScreenUpdating = true;
        }
        // Запись исходного и результирующего массива в Word
        public static void AddWord(int[] mas, int[] arr)

        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Wrd = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true
            };
            var inf = Type.Missing;
            string str;
            var Doc = Wrd.Documents.Add(inf);
            Wrd.Selection.TypeText("Массив Исходный и Массив Результирующий");
            object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            Microsoft.Office.Interop.Word.Table tbl = Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, 5, mas.Length, t1, t2);
            for (int i = 0; i < mas.Length; i++)
            {
                tbl.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i + 1) + "]");
                str = String.Format("{0:f0}", mas[i]);
                tbl.Cell(2, i + 1).Range.InsertAfter(str);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                tbl.Cell(3, i + 1).Range.InsertAfter("");
                tbl.Cell(4, i + 1).Range.InsertAfter("[" + Convert.ToString(i + 1) + "]");
                str = String.Format("{0:f0}", arr[i]);
                tbl.Cell(5, i + 1).Range.InsertAfter(str);
            }
        }
        // Создание базы данных Access
        public static void Add1()
        {
            var k = new ADOX.Catalog();
            var location =
            System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            try
            {
                k.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" +
                path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            }
            catch (System.Runtime.InteropServices.COMException exp)
            {
                MessageBox.Show(exp.Message, "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            finally
            {
                k = null;
            }
        }
        // Создание таблицы в Access
        public static void Add_struct1()

        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            var p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
                + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            p.Open();
            var c = new OleDbCommand("Create Table [results]([Элемент] counter," +
                "[Исходный массив] char(10), [Пробел] char(10), [Результирующий массив] char(10))", p);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            p.Close();
        }
        // Добавление исходного и резулььтируюшего массива в таблицу Access
        //Расмторены случаи, когда результируюещего массива нет
        public static void Add_zapi(int[] arr, int[] rarr, int len, int rlen)

        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            for (int i = 0; i < len; i++)
            {

                var p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                    "Data Source=" + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
                p.Open();
                if ((i < len - 1) & (rlen > 0))
                {
                    var c = new OleDbCommand("INSERT INTO [results](" + " [Исходный массив],[Результирующий массив])" +
                    "VALUES('" + arr[i] + "', '" + rarr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                    p.Close();
                }
                if ((i == len - 1) & (len > rlen) & (rlen > 0))
                {
                    var c = new OleDbCommand("INSERT INTO [results](" + " [Исходный массив])" +
"VALUES('" + arr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                    p.Close();
                }
                else if ((i == len - 1) & (len == rlen) & (rlen > 0))
                {
                    var c = new OleDbCommand("INSERT INTO [results](" + " [Исходный массив],[Результирующий массив])" +
                    "VALUES('" + arr[i] + "', '" + rarr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                    p.Close();
                }
                if (rlen == 0)
                {
                    var c = new OleDbCommand("INSERT INTO [results](" + " [Исходный массив])" +
"VALUES('" + arr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                    p.Close();
                }
            }
            MessageBox.Show("База данных создана", "Создание БД", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Заполнение массива случайными значениями
        public static void ArrGen(int[,] mas, int n, int m)
        {
            Random rnd = new Random();
            for (int i=0; i< n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                    mas[i, j] = Convert.ToInt16(rnd.Next(-100, 100));
                }
            }
        }
        // Вывод двумерного массива в datagridview
        public static void OutputArr(int[,] mas, int n, int m, DataGridView dgv)
        {
            dgv.ColumnCount = m + 1;
            dgv.RowCount = n + 1;
            dgv.Rows[0].Cells[0].Value = "[" + n + "]" + "[" + m + "]";
            for (int i = 0; i < n; i++)
            {
                dgv.Rows[i + 1].Cells[0].Value = "[" + i + "]";
                dgv.Rows[0].Cells[i + 1].Value = "[" + i + "]";
                for (int j = 0; j < m; j++)
                {
                    dgv.Rows[i + 1].Cells[j + 1].Value = mas[i, j];
                }
            }
        }
        //Подсчёт количества элементов, удовлетворяющих условию
        public static int Lab8(int[,] mas, int n, int m, int y)
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] > y)
                    {
                        k++;
                    }
                }
            }
            MessageBox.Show(Convert.ToString(k), "Количество чисел больше Y", MessageBoxButtons.OK, MessageBoxIcon.Information);
            arr8 = Class2.Mas8(mas, n, m);
            return k;
        }
        // Генерация результирующего массива
        public static void NewArr(int[,] mas, int n, int m, int z, DataGridView DGV)
        {
            int k = 0;
            // Подсчёт количества элементов результирующего массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] < z)
                    {
                        k++;
                    }
                }
            }
            // Создание результирующего массива
            int[] arr = new int[k];
            k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] < z)
                    {
                        arr[k] = mas[i, j];
                        k++;
                    }
                }
            }
            Class2.Output_mas(arr, k, DGV);
            Class2.arr = Class2.Mas(k, arr);
        }
        // Метод, добавляющий исходный и результирующий массивы в Блокнот
        public static void Bloknot(int[,] mas, int[] arr)
        {
            StreamWriter rez = File.CreateText("Лабораторная работа 8.txt");
            rez.WriteLine("Двумерный массив \n");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    rez.Write(mas[i, j] + "\t");
                }
                rez.WriteLine("\n");
            }
            rez.WriteLine("Результирующий массив \n");
            for (int z = 0; z < arr.Length; z++)
            {
                rez.Write(arr[z] + "\t");
            }
            rez.WriteLine("\n");
            rez.Close();
            System.Diagnostics.Process.Start("Лабораторная работа 8.txt");
        }
        // Метод, создающий таблицу для исходного массива
        public static void CreateStructDB(int m)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            var Connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
                + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            Connect.Open();
            String Col = "CREATE TABLE [Matrix] ([Rows] counter";
            for (int i = 0; i < m; i++)
                Col = Col + ", [" + "Col" + Convert.ToString(i + 1) + "] char(5)";
            var Command = new OleDbCommand(Col + ")", Connect);
            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("");
            }
            catch (System.Runtime.InteropServices.COMException exp)
            {
                MessageBox.Show(exp.Message);
            }
            Connect.Close();
        }
        // Заготовка для выполнения запроса в Access
        public static void CommBD(String commandString)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            var Connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
                + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            Connect.Open();
            var Command = new OleDbCommand("" + commandString);
            Command.Connection = Connect;
            Command.ExecuteNonQuery();
            Connect.Close();
        }
        // Метод, добавляющий исходный массив в базу данных Access
        public static void AddToBD(int n, int m, int[,] mas)
        {
            String cmdString;
            String cmdString2;
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            var Connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
                + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            Connect.Open();
            for (int i = 0; i < n; i++)
            {
                cmdString = "INSERT INTO [Matrix] ([Rows]";
                cmdString2 = ") VALUES (" + "'" + Convert.ToString(i + 1) + "'";
                for (int j = 0; j < m; j++)
                {
                    cmdString = cmdString + ", [Col" + Convert.ToString(j + 1) + "]";
                    cmdString2 = cmdString2 + ", '" + Convert.ToString(mas[i, j]) + "'";
                }
                cmdString2 = cmdString2 + ")";
                CommBD(cmdString + cmdString2);
                Connect.Close();
            }
            MessageBox.Show("");
        }
        // Метод, который создаёт таблицу и добавляет в неё результирующий массив в базу данных Access
        public static void AddR(int z, int [] mas)
        {
            // Создание таблицы
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);
            var Connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
                + path.ToString().Replace("\\", "\\\\") + "\\Results.mdb");
            Connect.Open();
            var c = new OleDbCommand("Create Table [results]([Результат] char(10))", Connect);
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            Connect.Close();
            //Добавление результируюшего массива
            String cmdString;
            String cmdString2;
            for ( int i = 0; i<z; i++)
            {
                Connect.Open();
                cmdString = "INSERT INTO [results] ([Результат]";
                cmdString2 = ") VALUES (" + "'" + Convert.ToString(i + 1) + "'";
                cmdString = cmdString + ", [Col" + Convert.ToString(z + 1) + "]";
                cmdString2 = cmdString2 + ", '" + Convert.ToString(mas[i]) + "'";
                cmdString2 = cmdString2 + ")";
                c = new OleDbCommand("INSERT INTO [results](" + " [Результат])" +
"VALUES('" + mas[i] + "')");
                c.Connection = Connect;
                c.ExecuteNonQuery();
                Connect.Close();
            }
        }
        // Метод, добавляющий исходный и результирующий массивы в Excel
        public static void ZapExcel(int n, int m, int[,] mas, int z)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(NameExcel1, 0, false, 5, "", "",
                false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet workSheet;
            workSheet = (Worksheet)ObjWorkBook.Worksheets.get_Item(1);
            workSheet.Name = "Массив исходный";
            int r = 0;
            workSheet.Cells[1, 1] = "Исходный массив";
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = mas[i, j];
                    r=j;
                }
            }
            workSheet.Cells[r+3, 1] = "Результирующий массив";
            for (int i = 0; i<z; i++)
            {
                workSheet.Cells[r + 4, i + 1] = "[" + i + "]";
                workSheet.Cells[r + 5, i + 1] = arr[i];
            }
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }
        // Метод, выполняющий записанный макрос в Excel
        public static void MakrosExcel()
        {
            Microsoft.Office.Interop.Excel.Application app = new
Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbooks books = app.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook book = null;
            book = books.Open(@"C:\Users\arbaa\OneDrive\Рабочий стол\%№;№%;№%\lab8.xlsm");
            app.Run((object)"lab");
            app.ScreenUpdating = true;
        }
        // Метод, добавляющий исходный и результирующий массивы в Word
        public static void ZV(int n, int m, int z)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Wrd = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true
            };
            var inf = Type.Missing;
            string str;
            var Doc = Wrd.Documents.Add(inf);
            Wrd.Selection.TypeText("Исходный массив");
            Object t1 = Microsoft.Office.Interop.Word.WdDefaultListBehavior.wdWord9ListBehavior;
            Object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            Microsoft.Office.Interop.Word.Table tbl =
                Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, m + 1, n + 1, t1, t2);
            for (int i =0; i<m; i++)
                tbl.Cell(i + 2, 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
            for (int j = 0; j < n; j++)
                tbl.Cell(1, j + 2).Range.InsertAfter("[" + Convert.ToString(j) + "]");
            for (int i = 0; i < m; i++)
            {
                for (int j =0; j<n; j++)
                {
                    str = String.Format("{0:f2}", arr8[i, j]);
                    tbl.Cell(i + 2, j + 2).Range.InsertAfter(str);
                }
            }
            Object t3 = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            Object add_str = n + 2;
            Wrd.Selection.MoveDown(t3, add_str, inf);
            Wrd.Selection.TypeText("Результирующий массив");
            tbl = Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, 2, z, t1, t2);
            for (int i = 0; i < z; i++)
            {
                tbl.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                str = String.Format("{0:f2}", arr[i]);
                tbl.Cell(2, i + 1).Range.InsertAfter(str);
            }
        }
    }
}
