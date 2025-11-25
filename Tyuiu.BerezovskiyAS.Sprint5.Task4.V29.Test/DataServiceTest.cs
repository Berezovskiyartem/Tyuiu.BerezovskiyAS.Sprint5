using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task4.V29.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\berez\source\repos\Tyuiu.BerezovskiyAS.Sprint5\Tyuiu.BerezovskiyAS.Sprint5.Task4.V29";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);
        }
    }
}
