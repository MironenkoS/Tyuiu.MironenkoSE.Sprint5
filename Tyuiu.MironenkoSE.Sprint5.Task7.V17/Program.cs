﻿using Tyuiu.MironenkoSE.Sprint5.Task7.V17.Lib;
namespace Tyuiu.MironenkoSE.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл находится по пути ...\\OutPutDataFileTask7V16.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V16.txt");
            string text = File.ReadAllText(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V16.txt" }));
            Console.WriteLine(text);
        }
    }
}
