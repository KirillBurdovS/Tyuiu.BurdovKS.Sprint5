


using Tyuiu.BurdovKS.Sprint5.Task2.V16.Lib;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #5 | Выполнил: Бурдов.К.С | СМАРТБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Бурдов Кирилл Сергеевич |  СМАРТБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int[,] mass = new int[3, 3];

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Console.Write($"Введите [{i},{j}] элемент массива: ");
                mass[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (j == mass.GetLength(1) - 1) Console.Write(mass[i, j]);
                else Console.Write(mass[i, j] + ", ");
            }
            Console.WriteLine();
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(mass);

        Console.WriteLine("Ответ записан в файл по пути:\n" + path);
        Console.WriteLine("\nПолученные значения: ");

        string[] massiv = File.ReadAllLines(path).ToArray();
        int[,] mass2 = new int[massiv.Length, massiv[0].Split(";").Length];

        for (int i = 0; i < massiv.Length; i++)
        {
            string[] temp = massiv[i].Split(";");
            for (int j = 0; j < temp.Length; j++)
                mass2[i, j] = Convert.ToInt32(temp[j]);
        }

        for (int i = 0; i < mass2.GetLength(0); i++)
        {
            for (int j = 0; j < mass2.GetLength(1); j++)
            {
                if (j == mass2.GetLength(1) - 1) Console.Write(mass2[i, j]);
                else Console.Write(mass2[i, j] + ", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.ReadLine();
    }
}