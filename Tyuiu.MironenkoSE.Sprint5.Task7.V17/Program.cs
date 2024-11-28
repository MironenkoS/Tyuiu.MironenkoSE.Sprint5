using Tyuiu.MironenkoSE.Sprint5.Task7.V17.Lib;
namespace Tyuiu.MironenkoSE.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
             DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Мироненко | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Мироненко С.Э| АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V17.txt в котором есть      *");
            Console.WriteLine("* набор символьных данных.Заменить все знаки препинания на #. Полученный  *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V17.txt.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var NewPath = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле: "+NewPath);
            Console.ReadKey();
        }
    }
}
