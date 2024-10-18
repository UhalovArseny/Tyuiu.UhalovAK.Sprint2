using Tyuiu.UhalovAK.Sprint2.Task5.V12.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 9;
            int n = 7;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(6 + "." + 9 + "." + 2024);

            Assert.AreEqual(wait, res);
        }
    }
}