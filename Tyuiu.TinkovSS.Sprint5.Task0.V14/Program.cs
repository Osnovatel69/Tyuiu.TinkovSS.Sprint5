using System;
using System.IO;
using Tyuiu.TinkovSS.Sprint5.Task0.V14.Lib;

namespace Tyuiu.TinkovSS.Sprint5.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Тиньков С. С. | ПКТб-xx-x";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый ввод/вывод данных                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-xx-x                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: y(x) = (4 * x^3) / (x^3 - 1)                            *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат сохранить в текстовый файл *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до 3 знаков.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл создан: " + res);
            Console.WriteLine("Значение из файла: " + File.ReadAllText(res));

            Console.ReadKey();
        }
    }
}