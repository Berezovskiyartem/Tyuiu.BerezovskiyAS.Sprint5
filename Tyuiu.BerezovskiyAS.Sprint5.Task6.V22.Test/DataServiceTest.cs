using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task6.V22.Lib;

namespace Tyuiu.BerezovskiyAS.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\berez\AppData\Local\Temp\DataSprint5\InPutDataFileTask6V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
