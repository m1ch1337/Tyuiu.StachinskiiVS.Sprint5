using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StachinskiiVS.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string strY = string.Empty;
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int x;
            double y;

            for (x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
                strY = Convert.ToString(y);
                if (x + 1.2 == 0) y = 0;

                if (x != stopValue) File.AppendAllText(path, strY + Environment.NewLine);
                else File.AppendAllText(path, strY);
            }

            return path;
        }
    }
}