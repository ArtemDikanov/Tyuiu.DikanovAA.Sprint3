using Tyuiu.DikanovAA.Sprint3.Task0.V20.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 0;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 4;

            Assert.AreEqual(wait, res);
            

        }
    }
}
