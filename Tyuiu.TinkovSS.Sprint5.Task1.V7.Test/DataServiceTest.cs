using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TinkovSS.Sprint5.Task1.V7.Lib;

namespace Tyuiu.TinkovSS.Sprint5.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string res = ds.SaveToFileTextData(startValue, stopValue);

            FileInfo fileInfo = new FileInfo(res);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}