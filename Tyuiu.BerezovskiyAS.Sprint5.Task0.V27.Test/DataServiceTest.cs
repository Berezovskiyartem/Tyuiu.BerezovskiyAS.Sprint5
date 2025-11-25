using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task0.V27.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\berez\AppData\Local\Temp\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);

            Assert.AreEqual(path, res);
        }
    }
}
