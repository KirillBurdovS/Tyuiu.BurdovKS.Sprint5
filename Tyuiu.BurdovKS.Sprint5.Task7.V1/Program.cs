



using Tyuiu.BurdovKS.Sprint5.Task7.V1.Lib;

using System.IO;



class Program
{
    static void Main(string[] args)
    {



        Console.Title = "Спринт #5 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask7V1.txt" });





        Console.WriteLine("данные находятся в файле " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.LoadDataAndSave(path);
        Console.WriteLine(res);

    }
}