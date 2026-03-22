using Tyuiu.StachinskiiVS.Sprint5.Task5.V8.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V8.txt");
            File.WriteAllText(path, "7 2.58 16.62 -3.36 14 3.09 -6 6.13 9.24 12 8 2.39 9.88 9 8.73 11 13 -4 18 20");
            double res = ds.LoadFromDataFile(path);
            double wait = -6;
            Assert.AreEqual(wait, res);
        }
    }
}