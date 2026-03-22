using Tyuiu.StachinskiiVS.Sprint5.Task6.V2.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V2.txt");
            File.WriteAllText(path, "Привет мир Hello world 123");
            int res = ds.LoadFromDataFile(path);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}