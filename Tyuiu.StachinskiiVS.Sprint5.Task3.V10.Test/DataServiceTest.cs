namespace Tyuiu.StachinskiiVS.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\stach\source\repos\Tyuiu.StachinskiiVS.Sprint5\Tyuiu.StachinskiiVS.Sprint5.Task3.V10\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileUnfo = new FileInfo(path);
            bool fileInfo = fileUnfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileInfo);
        }
    }
}