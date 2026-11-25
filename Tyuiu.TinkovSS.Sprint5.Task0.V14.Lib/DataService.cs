using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TinkovSS.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            // Получаем путь к временной папке системы и формируем имя файла
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Вычисление выражения: y(x) = (4 * x^3) / (x^3 - 1)
            double numerator = 4 * Math.Pow(x, 3);
            double denominator = Math.Pow(x, 3) - 1;
            double y = Math.Round(numerator / denominator, 3);

            // Сохраняем результат в файл
            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}