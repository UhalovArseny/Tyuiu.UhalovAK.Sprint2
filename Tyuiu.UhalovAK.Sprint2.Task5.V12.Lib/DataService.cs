using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UhalovAK.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int resG = g;
            int resM = m;
            int resN = n;
            switch (m)
            {
                case 1:
                    m = 012;
                    g -= 1;
                    break;
                case 3:
                    if (n == 1)
                    {
                        m = 02;
                        n = 028;

                        if (IsLeapYear(resG))
                        {
                            n = 029;
                        }
                    }
                    else
                    {
                        m -= 1;
                    }

                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    if (n == 1)
                    {
                        m -= 01;
                        n = 031;
                    }
                    else
                    {
                        n = n - 1;
                    }

                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        m -= 01;
                        n = 030;
                    }
                    else
                    {
                        n = n - 1;
                    }

                    break;
            }

            bool IsLeapYear(int year)
            {
                return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            }

            string res = "0" + Convert.ToString(n) + "." + "0" + Convert.ToString(m) + "." + Convert.ToString(g);

            return res;
        }
    }
}
 