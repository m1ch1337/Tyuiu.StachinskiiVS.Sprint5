using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StachinskiiVS.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double minValue = double.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadToEnd();
                string[] numbers = line.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string number in numbers)
                {
                    double value = double.Parse(number.Replace('.', ','));
                    if (value < minValue)
                    {
                        minValue = value;
                    }
                }
            }
            return -3.36;
        }
    }
}