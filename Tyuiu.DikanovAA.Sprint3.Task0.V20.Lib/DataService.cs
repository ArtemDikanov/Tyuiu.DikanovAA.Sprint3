using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DikanovAA.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries * (Math.Cos(value) + Math.Pow((startValue / 8), 3));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
