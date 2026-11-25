namespusing Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TinkovSS.Sprint5.Task0.V14.Lib;

namespace Tyuiu.TinkovSS.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string res = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(res);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}