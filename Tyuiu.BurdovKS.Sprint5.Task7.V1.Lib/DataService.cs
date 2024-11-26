



using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;


using System.IO;



namespace Tyuiu.BurdovKS.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {



            //string pathSaveFile = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint5\Tyuiu.BurdovKS.Sprint5.Task7.V1\bin\Debug\net8.0OutPutDataFileTask7V1.txt";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.", path);
            }

            // Создаем путь к выходному файлу
            string pathSaveFile = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint5\Tyuiu.BurdovKS.Sprint5.Task7.V1\bin\Debug\net8.0\OutPutDataFileTask7V1.txt";

            // Проверяем, существует ли выходной файл
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            // Если выходной файл существует, удаляем его
            if (fileExists)
            {
                fileInfo.Delete();
            }

            // Считываем данные из входного файла и удаляем символы новой строки в конце
            string data = File.ReadAllText(path).TrimEnd();

            // Удаляем все цифры из данных
            data = Regex.Replace(data, @"\d", "");

            // Записываем данные во временный файл
            File.WriteAllText(pathSaveFile, data);

            // Возвращаем путь к выходному файлу
            return pathSaveFile;
        }
    }
}

