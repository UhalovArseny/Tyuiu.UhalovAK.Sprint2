﻿using Tyuiu.UhalovAK.Sprint2.Task0.V7.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
                Console.ReadKey();
            
        }
    }
}
