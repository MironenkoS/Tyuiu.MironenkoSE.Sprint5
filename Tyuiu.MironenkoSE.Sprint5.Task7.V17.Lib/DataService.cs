using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MironenkoSE.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path) 
        {
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("нн", "");
                    str += line;
                }
            }
            string NewPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");
            FileInfo f = new FileInfo(NewPath);
            if (f.Exists) File.Delete(NewPath);
            File.AppendAllText(NewPath, str);
            return NewPath;

        }
    }
}
