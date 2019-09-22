using System;

namespace Фоновые_задачи
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            double a1 = (double)a;
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());
            double b1 = (double)b;
            Console.Write("c:");
            int c = int.Parse(Console.ReadLine());
            double c1 = (double)c;
            double result = Math.Pow((c + b), 1.0 / 3) + Math.Sin(a / 4) + Math.Sqrt((a + b + 4.0) / 2) + Math.Pow(c, 2);*/
            // Console.WriteLine("{0:F}", result);

            double x = -0.2;
            double y = 0.69;
            double U = Math.Abs(x)+ (y * 2.0)  ;
            Console.WriteLine(U);
            Console.ReadKey();
        }
    }
}