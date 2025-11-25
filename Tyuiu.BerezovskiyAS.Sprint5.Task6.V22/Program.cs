using System.IO;
using Tyuiu.BerezovskiyAS.Sprint5.Task6.V22.Lib;

{
    DataService ds = new DataService();


    Console.Title = "Спринт #5 | Выполнил: Березовский А. С. | ПИНб-25-1";

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #22                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Дан файл (файл взять из архива согласно вашему варианту. Создать папку  *");
    Console.WriteLine("* в ручную и скопировать в неё файл) в котором есть набор символьных      *");
    Console.WriteLine("* данных. Найти количество удвоенных букв мм в заданной строке.           *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string path = @"C:\Users\berez\AppData\Local\Temp\DataSprint5\InPutDataFileTask6V22.txt";
    Console.WriteLine("Данные находятся в файле: " + path);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");



    double res = ds.LoadFromDataFile(path);

    Console.WriteLine(res);
    Console.ReadKey();
}