using Tyuiu.StachinskiiVS.Sprint5.Task7.V7.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Стачинский В.С. | ИСПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Стачинский В.С. | ИСПБ-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все заглавные *");
            Console.WriteLine("* русские буквы из файла. Полученный результат сохранить в файл.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V7.txt");
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V7.txt");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Файл {inputPath} не найден!");
                Console.WriteLine("Создайте папку C:\\DataSprint5 и скопируйте в неё файл InPutDataFileTask7V7.txt");
                Console.ReadKey();
                return;
            }

            string fileContent = File.ReadAllText(inputPath);
            Console.WriteLine($"Путь к входному файлу: {inputPath}");
            Console.WriteLine($"Содержимое входного файла: {fileContent}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(inputPath);
            Console.WriteLine($"Результат после удаления заглавных русских букв: {result}");
            Console.WriteLine($"Результат сохранен в файл: {outputPath}");
            Console.ReadKey();
        }
    }
}