using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MironenkoSE.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(path); }

            double res;
            string strRes;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round((3*Math.Cos(x)/(4*x-0.5))+Math.Sin(x)-5*x-2,2);
                strRes = Convert.ToString(res);

                if (4 * x - 0.5 == 0)
                {
                    File.AppendAllText(path, "0");
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }
            return path;
        }
    }
}
