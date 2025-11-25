using Tyuiu.BerezovskiyAS.Sprint5.Task2.V25.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнил: Березовский А. С.  | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #25                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("*                                                                         *");

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int[,] matrix = new int[3, 3] { { 4, 8, 5 }, { 1, 4, 2 }, { 4, 9, 9 } };
    int rows = matrix.GetUpperBound(0) + 1;
    int cols = matrix.GetUpperBound(1) + 1;

    Console.WriteLine("Массив:: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }


    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    string res = ds.SaveToFileTextData(matrix);
    Console.WriteLine("Файл: " + res);
    Console.WriteLine("Создан!!");
    Console.ReadKey();
}