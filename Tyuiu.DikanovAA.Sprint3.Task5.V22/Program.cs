using Tyuiu.DikanovAA.Sprint3.Task5.V22.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

           
            Console.WriteLine("Ответ: " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            

        }
    }
}
