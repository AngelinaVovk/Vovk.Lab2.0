using System;
namespace Vovk.Lab22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 1 / 47.0 + 1 / Math.Log(x) + 7 * x / 2.0 + Math.Max(x, 1 / 3) + 2 * Math.Cos(x / 3) + Math.Pow(2, x) + 1;
            Console.WriteLine("Значение функции равно: " + f);
        }
    }
}
               