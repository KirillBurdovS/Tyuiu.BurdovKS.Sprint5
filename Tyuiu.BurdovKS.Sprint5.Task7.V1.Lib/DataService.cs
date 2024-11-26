



using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;


using System.IO;



namespace Tyuiu.BurdovKS.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {



            string pathSaveFile = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint5\Tyuiu.BurdovKS.Sprint5.Task7.V1\bin\Debug\net8.0OutPutDataFileTask7V1.txt";

            // Проверяем, существует ли файл
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }

            // Считываем данные из файла
            string data = File.ReadAllText(path);

            // Удаляем все цифры из данных
            data = Regex.Replace(data, @"\d", "");

            // Создаем временный файл с уникальным именем
            string outpath = Path.GetTempFileName();

            // Записываем данные во временный файл
            File.WriteAllText(outpath, data);

            return outpath;
        }
    }
}
