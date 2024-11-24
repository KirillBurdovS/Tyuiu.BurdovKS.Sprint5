




using tyuiu.cources.programming.interfaces.Sprint5;


using System.IO;

namespace Tyuiu.BurdovKS.Sprint5.Task1.V2.Lib
{


    public class DataService : ISprint5Task1V2

    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }



            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6, 2);
                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;





        }
    }
}
