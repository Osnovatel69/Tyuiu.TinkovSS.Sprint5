using System;
using System.IO;
using Tyuiu.TinkovSS.Sprint5.Task1.V7.Lib;

namespace Tyuiu.TinkovSS.Sprint5.Task1.V7
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-xx-x                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Произвести табулирование функции F(x) = (sin(x)/(x+1.2)) - sin(x)*2 - 2x*");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Результат сохранить в текстовый файл   *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в виде таблицы.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            string[] lines = File.ReadAllLines(res);
            int currentX = startValue;

            foreach (string line in lines)
            {
                Console.WriteLine("| {0,8} | {1,8} |", currentX, line);
                currentX++;
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("Файл создан: " + res);

            Console.ReadKey();
        }
    }
}