using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task2.V25.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"D:\source\repos\Tyuiu.BerezovskiyAS.Sprint5\Tyuiu.BerezovskiyAS.Sprint5.Task2.V25\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
