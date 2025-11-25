using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task7.V6.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
