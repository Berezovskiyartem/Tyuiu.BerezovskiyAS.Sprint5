using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task2.V25.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\berez\source\repos\Tyuiu.BerezovskiyAS.Sprint5\Tyuiu.BerezovskiyAS.Sprint5.Task2.V25\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinf = new FileInfo(path);
            bool fileExists = fileinf.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
