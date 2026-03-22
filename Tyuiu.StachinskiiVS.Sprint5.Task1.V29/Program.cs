using Tyuiu.StachinskiiVS.Sprint5.Task1.V29.Lib;

Console.Title = "Спринт #4 | Выполнил: Стачинский В. С. | ИСПб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Стачинский В. С. | ИСПб-24-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить выражение и вывести его в файл .txt                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();

Console.WriteLine("Начальное значение диапазона = " + startValue);
Console.WriteLine("Конечное значение диапазона = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
