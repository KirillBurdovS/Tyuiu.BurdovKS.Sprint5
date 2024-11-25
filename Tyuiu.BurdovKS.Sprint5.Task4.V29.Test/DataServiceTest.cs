



using Tyuiu.BurdovKS.Sprint5.Task4.V29.Lib;

namespace Tyuiu.BurdovKS.Sprint5.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V0.txt" });
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}