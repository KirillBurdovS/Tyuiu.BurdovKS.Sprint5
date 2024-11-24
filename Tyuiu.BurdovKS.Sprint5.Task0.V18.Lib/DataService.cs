
using tyuiu.cources.programming.interfaces.Sprint5; 
using System;
using System.IO;

namespace Tyuiu.BurdovKS.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");


            double y = x / (Math.Sqrt(Math.Pow(x, 2) + x));
            y = Math.Round(y, 3, MidpointRounding.AwayFromZero);

           
            File.WriteAllText(path, y.ToString("F3")); 

            return path;
        }
    }
}
