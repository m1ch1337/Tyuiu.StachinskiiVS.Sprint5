using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StachinskiiVS.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            double z = -1 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 3 / 2.0 * x;
            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return path;
        }
    }
}