using Tyuiu.UhalovAK.Sprint2.Task6.V3.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("�����������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(1));
            Assert.AreEqual("�����", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(1));
            Assert.AreEqual("�����������", ds.FindDayName(1));

        }
    }
}