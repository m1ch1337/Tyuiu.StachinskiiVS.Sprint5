using Tyuiu.StachinskiiVS.Sprint5.Task4.V12.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V12.txt");
            File.WriteAllText(path, "2.5");
            double res = ds.LoadFromDataFile(path);
            double wait = Math.Round(Math.Pow(2.5, 3) - Math.Pow(2.5, 2) + (4 * 2.5) - 8, 3);
            Assert.AreEqual(wait, res);
        }
    }
}