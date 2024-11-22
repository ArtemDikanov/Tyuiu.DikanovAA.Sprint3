using Tyuiu.DikanovAA.Sprint3.Task7.V27.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+------------+-------------+");
            Console.WriteLine("|     X      |      f(x)   |");
            Console.WriteLine("+------------+-------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,5:d}      |   {1, 6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+------------+-------------+");
            Console.ReadKey();
        }
    }
}
