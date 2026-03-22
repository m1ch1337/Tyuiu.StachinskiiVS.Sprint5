using Tyuiu.StachinskiiVS.Sprint5.Task6.V2.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стачинский В. С. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Стачинский В. С. | ИСПб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Найти количество      *");
            Console.WriteLine("* русских букв в заданной строке.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V2.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл {path} не найден!");
                Console.WriteLine("Создайте папку C:\\DataSprint5 и скопируйте в неё файл InPutDataFileTask6V2.txt");
                Console.ReadKey();
                return;
            }

            string fileContent = File.ReadAllText(path);
            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Содержимое файла: {fileContent}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество русских букв: {result}");
            Console.ReadKey();
        }
    }
}