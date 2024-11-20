using Tyuiu.DikanovAA.Sprint3.Task4.V10.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double wait = 0.014;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);



        }
    }
}