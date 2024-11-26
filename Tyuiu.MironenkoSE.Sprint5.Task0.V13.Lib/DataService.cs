using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MironenkoSE.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double res = (-1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x);
            res = Math.Round(res, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
