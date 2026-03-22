using Tyuiu.StachinskiiVS.Sprint5.Task2.V4.Lib;

namespace Tyuiu.StachinskiiVS.Sprint5.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { 5, -5, -6 }, { -5, 6, -7 }, { 7, 3, 5 } };
            string savedPath = ds.SaveToFileTextData(matrix);
            bool fileExists = File.Exists(savedPath);
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            if (fileExists)
            {
                File.Delete(savedPath);
            }
        }
    }
}