using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //7
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double U = 0.0;
            //проверка левой четверти
            if (x <= 0.0)
                if (x >= -1.0)
                    if (y >= 0.0)
                        if (y <= 1.0)
                            // U = Math.Sqrt(Math.Abs(2.0 * y + x));
                            Console.WriteLine("Yes");


                        else

                            //U = x / Math.Pow(y, 2.0);
                            Console.WriteLine("No");
          


            //проверка правой четверти с вырезом
            if (x >= 0.0)
     
                if (x <= 1)
                    if (y >= 0.3)
                        if (y <= 1.0)
                            //U = Math.Sqrt(Math.Abs(2.0 * y + x));
                Console.WriteLine("Yes");
         

            else
            
                // U = x / Math.Pow(y, 2.0);
                Console.WriteLine("No");
            

            Console.WriteLine("{0:G3}", U);

            Console.ReadKey();
        }
    }
}
