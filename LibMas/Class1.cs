using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace LibMas
{
    public class Class2
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="mas"//массив ></param>
    /// <param name="column"// число колонок в массиве></param>
    /// <param name="randMax"// рандомизация></param>
        public static void InitArray(out int[] mas, int column, int randMax)
        {
            Random Rnd; Rnd = new Random();
            mas = new Int32[column];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Rnd.Next(-10,randMax);//заполняем массив случайными значениями в диапозоне от -10
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"//массив></param>
        /// <param name="column"//число колонок в массиве></param>
        public static void CreateArray(out int[] mas, int column)
        {
            mas = new int[column];//создаем массив
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"//массив></param>
        public static void SaveArray(int[] mas)
        {
            //создаем и настраиваем элемент SaveFileDialog
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            DialogResult dialogResult = save.ShowDialog();
            bool t = Convert.ToBoolean(dialogResult);
            //открываем диалоговое окно и при успехе работаем с файлом
            if (t == true)
            {
                
                StreamWriter file = new StreamWriter(save.FileName);//создаем поток для работы с файлом и указываем ему имя файла
                file.WriteLine(Convert.ToString(mas.Length));//записываем размер массива в файл
                for (int i = 0; i < mas.Length; i++)//записываем элементы массива в файл
                {
                    file.WriteLine(mas[i]);
                }
                file.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"//массив></param>
        public static void OpenArray(out int[] mas)
        {
            
            mas = new int[1];
            //создаем и настраиваем элемент OpenFileDialog
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицы";
            DialogResult dialogResult = open.ShowDialog();
            bool t = Convert.ToBoolean(dialogResult);
            //открываем диалоговое окно и при успехе работаем с файлом
            if (t == true)
            {
                StreamReader file = new StreamReader(open.FileName);//создаем поток для работы с файлом и указываем ему имя файла
                int column = Convert.ToInt32(file.ReadLine());//читаем размер 
                mas = new Int32[column];//создаем массив
                for (int i = 0; i < column; i++)//считываем массив из файла
                {
                    mas[i] = Convert.ToInt32(file.ReadLine());
                }
                file.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas"//массив></param>
        public static void CleanArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
            }
        }
    }
}