using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MironenkoSE.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string content;
            using (StreamReader sr = new StreamReader(path))
            {
                content = sr.ReadToEnd().Trim();
            }

            double x;
            if (!double.TryParse(content, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                content = content.Replace('.', ',');
            }

            double y = Math.Round(1 / (Math.Cos(x) + x) - 4.12 * x, 3);

            return Math.Round(y, 3);
        }
    }
}
