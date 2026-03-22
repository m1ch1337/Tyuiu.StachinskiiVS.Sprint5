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
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");
            File.WriteAllText(path, "2.5");
            double res = ds.LoadFromDataFile(path);
            double wait = Math.Round(Math.Cos(Math.Pow(2.5, 3)) + (2.5 / 2), 3);
            Assert.AreEqual(wait, res);
        }
    }
}