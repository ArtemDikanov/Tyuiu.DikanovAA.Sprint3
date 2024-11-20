using Tyuiu.DikanovAA.Sprint3.Task3.V5.Lib;
namespace Tyuiu.DikanovAA.Sprint3.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';

            Console.WriteLine("Ответ: " + ds.ReplaceCharInString(value, replaceable, replacement));
        }
    }
}
