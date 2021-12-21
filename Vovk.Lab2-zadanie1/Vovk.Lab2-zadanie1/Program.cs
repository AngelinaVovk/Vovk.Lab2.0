using System;
namespace Vovk.Lab21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение стороны b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение угла с (в градусах)");
            double x = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b - Math.Cos(x));
            Console.WriteLine("Сторона с = " + c);
            double y = Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2) / 2 * a * c;
            double z = Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2) / 2 * a * b;
            Console.WriteLine("Косинус b равен:" + y);
            Console.WriteLine("Косинус с равен:" + z);
        }
    }
}



            




