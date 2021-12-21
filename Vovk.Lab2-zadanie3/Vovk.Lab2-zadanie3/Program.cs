using System;
namespace Vovk.Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения x,y,z");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double f = 1 / 47.0 + 1 / Math.Log(y) + 7 * z / 2 + Math.Max(x, 1 / 3.0);
            Console.WriteLine("Значение функции равно:" + f);
        }
    }
}
