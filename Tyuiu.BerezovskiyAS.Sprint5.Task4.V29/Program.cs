using Tyuiu.BerezovskiyAS.Sprint5.Task4.V29.Lib;
using System.IO;

{
    DataService ds = new DataService();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
    Console.WriteLine("***************************************************************************");
    string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
    Console.WriteLine("Данные находятся в файле " + path);
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    double res = ds.LoadFromDataFile(path);
    Console.WriteLine(res);
    Console.ReadKey();
}