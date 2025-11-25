using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task1.V2.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 0;
            int end = 1;
            string path = ds.SaveToFileTextData(start, end);
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
