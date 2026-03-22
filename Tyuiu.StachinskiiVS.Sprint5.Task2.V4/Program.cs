using Tyuiu.StachinskiiVS.Sprint5.Task2.V4.Lib;

int[,] mtrx = new int[3, 3] { { 5, -5, -6 }, { -5, 6, -7 }, { 7, 3, 5 } };
int rows = mtrx.GetUpperBound(0) + 1;
int columns = mtrx.Length / rows;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Стачинский В.С. | ИСПБ-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("*Спринт #5                                                                *");
Console.WriteLine("* Тема:                                                                   *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Стачинский В.С. | ИСПБ-24-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
Console.WriteLine("* вывести на консоль.                                                     *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(mtrx);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();