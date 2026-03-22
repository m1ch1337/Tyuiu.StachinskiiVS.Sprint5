using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StachinskiiVS.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string result = "";

            foreach (char c in text)
            {
                if (!((c >= 'А' && c <= 'Я') || c == 'Ё'))
                {
                    result += c;
                }
            }

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V7.txt");
            File.WriteAllText(outputPath, result);

            return result;
        }

       
    }
}