using Tyuiu.StachinskiiVS.Sprint5.Task7.V7.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V7.txt");
            File.WriteAllText(path, "Привет Мир Hello World 123 АБВ");
            string res = ds.LoadDataAndSave(path);
            string wait = "ривет ир Hello World 123 ";
            Assert.AreEqual(wait, res);
        }
    }
}