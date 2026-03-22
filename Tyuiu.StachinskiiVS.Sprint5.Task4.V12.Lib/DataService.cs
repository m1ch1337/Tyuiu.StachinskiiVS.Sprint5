using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StachinskiiVS.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            double x = double.Parse(data.Replace('.', ','));
            double result = Math.Pow(x, 3) - Math.Pow(x, 2) + (4 * x) - 8;
            return Math.Round(result, 3);
        }
    }
}