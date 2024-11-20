using Tyuiu.DikanovAA.Sprint3.Task4.V10.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Ответы: " + ds.Calculate(startValue, stopValue));
        }
    }
}
