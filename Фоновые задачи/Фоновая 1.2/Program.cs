using System;

namespace Фоновая_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // вариант 7
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double U = 0.0;
            //проверка на попадание в D
            //1.08627804912002
            if (y * y + x * x <= 1.0)
            {
                if (x <= 0.0)

                    if (x >= -1.0)

                        if (y >= 0.0)

                            if (y <= 1.0)
                                U = Math.Sqrt(Math.Abs(2.0 * y + x));
                            else U = x / Math.Pow(y, 2.0);

                if (x >= 0.0)
                    if (x >= 0.3)
                        if (x <= 1.0)
                            if (y >= 0.3)
                                if (y <= 1.0)
                                    U = Math.Sqrt(Math.Abs(2.0 * y + x));
                                else U = x / Math.Pow(y, 2.0);
            }

            else U = x / Math.Pow(y, 2.0);

            Console.WriteLine(U);
            Console.ReadKey();
        }
    }
}