using Tyuiu.UhalovAK.Sprint2.Task4.V5.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(12, ds.Calculate(1, 1));
        }
    }
}