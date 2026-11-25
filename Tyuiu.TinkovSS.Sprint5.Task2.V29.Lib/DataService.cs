using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TinkovSS.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            // Если файл уже существует — удаляем старую версию
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Если элемент нечетный — заменяем на 0
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                    // Формируем CSV строку с разделителем ';'
                    str += matrix[i, j];

                    if (j != columns - 1)
                    {
                        str += ";";
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + "\n");
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";
            }

            return path;
        }
    }
}