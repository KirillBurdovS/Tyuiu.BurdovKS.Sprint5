



using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.BurdovKS.Sprint5.Task3.V22.Lib
{
    public class DataService : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");


            double z;
            double y;

            z = (Math.Pow(1 - x, 2))/(-3 * x);

            y = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;


        }
    }
}
