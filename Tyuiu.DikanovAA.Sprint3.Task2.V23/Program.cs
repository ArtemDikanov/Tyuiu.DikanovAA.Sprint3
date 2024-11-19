using Tyuiu.DikanovAA.Sprint3.Task2.V23.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
