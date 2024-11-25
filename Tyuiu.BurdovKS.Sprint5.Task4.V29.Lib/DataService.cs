


using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.BurdovKS.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {

            string strX = File.ReadAllText(path).Trim();

            if (string.IsNullOrWhiteSpace(strX))
            {
                throw new FormatException("Файл пуст или не содержит данных.");
            }

            double y;
            double x;

            if (!double.TryParse(strX, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                throw new FormatException($"Строка '{strX}' не содержит корректное числовое значение.");
            }

            double temp = Convert.ToDouble(x);


            if (temp == 0) y = -1;
            else y = Math.Round((temp / (2 * temp) + Math.Sin(Math.Pow(temp, 2))), 3);

            return y;








        }
    }
}