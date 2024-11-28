﻿using Tyuiu.MironenkoSE.Sprint5.Task6.V15.Lib;
namespace Tyuiu.MironenkoSE.Sprint5.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("В строке находится " + ds.LoadFromDataFile(path) + " удвоенных букв \"с\"");
            Console.ReadKey();
        }
    }
}
