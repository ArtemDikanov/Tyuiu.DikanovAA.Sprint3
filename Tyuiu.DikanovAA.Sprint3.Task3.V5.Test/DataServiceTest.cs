using Tyuiu.DikanovAA.Sprint3.Task3.V5.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';

            string wait = "fif* *l f*ll";
            string res = ds.ReplaceCharInString(value, replaceable, replacement);

            Assert.AreEqual(wait, res);


        }
    }
}