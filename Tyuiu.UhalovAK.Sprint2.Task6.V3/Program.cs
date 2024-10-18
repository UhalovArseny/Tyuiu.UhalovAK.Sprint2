using Tyuiu.UhalovAK.Sprint2.Task6.V3.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуе-*");
            Console.WriteLine("* мое значение и возвращает результат.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((numDay < 1) || (numDay > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это день недели: " +  ds.FindDayName(numDay);
            }
 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
