using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
namespace Tyuiu.MironenkoSE.Sprint5.Task3.V17.Lib
{
    public class DataService : ISprint5Task3V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append)))
            {
                writer.Write(Math.Round(2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1, 3));

            }

            return path;
        }
    }
}
