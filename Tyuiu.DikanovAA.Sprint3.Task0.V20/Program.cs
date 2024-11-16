using Tyuiu.DikanovAA.Sprint3.Task0.V20.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
            //
            Console.ReadKey();

        }
    }
}

