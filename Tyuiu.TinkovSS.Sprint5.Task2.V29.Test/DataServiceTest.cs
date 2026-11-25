using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TinkovSS.Sprint5.Task2.V29.Lib;

namespace Tyuiu.TinkovSS.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 9, 2, 5 },
                { 3, 2, 4 },
                { 2, 8, 8 }
            };

            string res = ds.SaveToFileTextData(matrix);

            // Проверка, что файл действительно создается
            bool fileExists = File.Exists(res);
            Assert.AreEqual(true, fileExists);
        }
    }
}