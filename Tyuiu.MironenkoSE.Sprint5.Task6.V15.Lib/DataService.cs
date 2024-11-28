using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MironenkoSE.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            string str = File.ReadAllText(path);
            str = str.ToUpper().Replace("СС", "*");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    cnt =5;
                }
            }
            return cnt;
        }
    }
}
