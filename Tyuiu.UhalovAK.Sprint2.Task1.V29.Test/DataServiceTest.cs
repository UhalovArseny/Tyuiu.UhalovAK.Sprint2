using Tyuiu.UhalovAK.Sprint2.Task1.V29.Lib;
namespace Tyuiu.UhalovAK.Sprint2.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            bool[] wait = new bool[6] { true, true, true, false, true, true };

            CollectionAssert.AreEqual(wait, res);


        }
    }
}