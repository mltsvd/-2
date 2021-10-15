using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace Lib_10
    
{
   
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mas" //массив ></param>
        /// <param name="s1" //строка для вывода результатов вычислений></param>
        
        public static void Radikal (int [] mas,out string s1)
        {
            int i;
            double rez = 0;
            s1 = " ";
            for ( i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)//проверяем элемент массива больше 0 или нет
                {
                    rez = Math.Sqrt(mas[i]);//находим корень числа
                    s1 =s1  + rez.ToString() + ";\n";// заполняем строку для вывода результатов вычислений
                }
            }
        }

    }
}
