


using Tyuiu.BurdovKS.Sprint5.Task3.V22.Lib;


namespace Tyuiu.BurdovKS.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint5\Tyuiu.BurdovKS.Sprint5.Task3.V22\bin\Debug";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);



        }
    }
}