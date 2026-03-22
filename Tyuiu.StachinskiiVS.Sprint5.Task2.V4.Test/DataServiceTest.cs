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
            string path = @" C:\Users\stach\source\repos\Tyuiu.StachinskiiVS.Sprint5\Tyuiu.StachinskiiVS.Sprint5.Task2.V4\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}