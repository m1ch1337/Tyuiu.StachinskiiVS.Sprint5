using Tyuiu.StachinskiiVS.Sprint5.Task5.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Стачинский В.С. | ИСПб-24-1 ";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка файлов                                                  *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Стачинский В.С. | ИСПб-24-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти минимальное вещественное число в файле.                           *");


Console.WriteLine("*                                                                         *");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("**************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine("Минимальное вещественное число: " + res);
Console.ReadKey();