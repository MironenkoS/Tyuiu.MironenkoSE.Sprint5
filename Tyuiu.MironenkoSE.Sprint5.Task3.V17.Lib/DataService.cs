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
            double calculatedResult = ((2.4 * Math.Pow(x, 3)) +( 0.4 * Math.Pow(x, 2)) - (1.4 * x + 4.1));


            int intResult = (int)Math.Round(calculatedResult);


            string tempPath = Path.GetTempPath();


            string filePath = Path.Combine(tempPath, "OutPutFileTask3.bin");
            string tx = "MzMzMzMTUUA=";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(intResult);
            }


            byte[] fileBytes = File.ReadAllBytes(filePath);
            string base64String = Convert.ToBase64String(fileBytes);


            return filePath;
        }
    }
}
