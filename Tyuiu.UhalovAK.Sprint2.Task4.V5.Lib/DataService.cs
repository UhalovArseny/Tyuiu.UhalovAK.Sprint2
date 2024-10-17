using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.UhalovAK.Sprint2.Task4.V5.Lib
{
    public class DataService : ISprint2Task4V5
    {
        public double Calculate(double x, double y)
        {
            var z = 0.0;
            z = x > y + 5 ? (y * Math.Pow((x + 2) / (y + 5), x)) : (x * x + 10 * x + 1 / y);
            return Math.Round(z, 3);
        }
    }
}
