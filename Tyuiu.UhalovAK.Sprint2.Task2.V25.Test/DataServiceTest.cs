using Tyuiu.UhalovAK.Sprint2.Task2.V25.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 6;
            
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);


        }
    }
}