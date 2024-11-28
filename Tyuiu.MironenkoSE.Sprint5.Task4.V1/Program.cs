using Tyuiu.MironenkoSE.Sprint5.Task4.V1.Lib;
namespace Tyuiu.MironenkoSE.Sprint5.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Мироненко С.Э. | АСОиУБ-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Чтение данных из текстового файла                                            *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнил: Мироненко Сергей Эдуардович | АСОиУБ-24-1                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл                                                                     *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формул                   *");
            Console.WriteLine("* Math.Round(1 / (Math.Cos(x) + x) - 4.12 * x, 3)                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\Users\664\source\repos\Tyuiu.MironenkoSE.Sprint5\DataSprint5\InPutDataFileTask4V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
