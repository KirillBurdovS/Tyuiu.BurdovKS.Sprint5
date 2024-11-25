


using Tyuiu.BurdovKS.Sprint5.Task5.V24.Lib;


namespace Tyuiu.BurdovKS.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V24.txt" });
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);




        }
    }
}