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

            
            int startValue = 1;
            int stopValue = 16;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 51191.405;

            Assert.AreEqual(wait, res);


        }
    }
}

