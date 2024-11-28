using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MironenkoSE.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string filePath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V15.txt" });
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(filePath);
            }
            string n = File.ReadAllText(path);
            string[] array = n.Split(' ');
            string[] newarray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length != 2)
                {
                    newarray[i] = array[i] + " ";
                }
                else
                {
                    newarray[i] = "";
                }
            }
            string result = string.Join("", newarray);
            File.AppendAllText(filePath, result);
            return filePath;

        }
    }
}
