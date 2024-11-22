using Tyuiu.DikanovAA.Sprint3.Task6.V20.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;

            Console.WriteLine("Ответ: " +  ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();

        }
    }
}
