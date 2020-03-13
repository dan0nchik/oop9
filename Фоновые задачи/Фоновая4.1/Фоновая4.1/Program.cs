using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая4._1
{
    
   
    class MatrixWeather {
        static Random rnd = new Random();
        public enum Months{
        Январь = 1,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль ,
        Август ,
        Сентябрь ,
        Октябрь ,
        Ноябрь ,
        Декабрь 
    }
        public int[] monthAr = {31,29,31,30,31,30,31,31,30,31,30,31}; 
        private int month;
        private int day;
        private int[,] temperature;
        public MatrixWeather()
        {
            month = 1;
            day = 1;
            temperature = new int[5, 7];
            GenTemp(month, temperature);
        }
        public MatrixWeather(int month, int day)
        {
            //if (Enum.IsDefined(typeof(Months), month))
            //{
            //    _ = ((Months)month).ToString();
            //}
            //this.month = (Months)Enum.GetValues(typeof(Months)).GetValue(month-1);
            this.month = month;
            this.day = day;
            if(day != 1)
            {
                temperature = new int[5, 7];
            }
            else
            {
                temperature = new int[4, 7];
            }
            GenTemp(month, temperature);
        }
        private static int[,] GenTemp(int month, int[,] diary)
        {
            for(int i = 0; i < diary.GetLength(0); i++)
            for (int j = 0; j < diary.GetLength(1); j++)
            {
                switch(month){
                        case 1:
                            diary[i, j] = rnd.Next(-10, -5);
                            break;
                        case 2:
                            diary[i, j] = rnd.Next(-10, -3);
                            break;
                        case 3:
                            diary[i, j] = rnd.Next(-5, 2);
                            break;
                        case 4:
                            diary[i, j] = rnd.Next(2, 11);
                            break;
                        case 5:
                            diary[i, j] = rnd.Next(8, 19);
                            break;
                        case 6:
                            diary[i, j] = rnd.Next(12, 22);
                            break;
                        case 7:
                            diary[i, j] = rnd.Next(14, 24);
                            break;
                        case 8:
                            diary[i, j] = rnd.Next(12, 22);
                            break;
                        case 9:
                            diary[i, j] = rnd.Next(7, 16);
                            break;
                        case 10:
                            diary[i, j] = rnd.Next(2, 8);
                            break;
                        case 11:
                            diary[i, j] = rnd.Next(-3, 1);
                            break;
                        case 12:
                            diary[i, j] = rnd.Next(-7, -3);
                            break;
                    }
            }
            //foreach (int i in diary)
            //    Console.Write(i + " ");
            return diary;
        }
        public void Output()
        {
           int dayNum = 1;
            int i1 = 0, j1 = 0, j = day;
           Console.WriteLine((Months)Enum.GetValues(typeof(Months)).GetValue(month - 1));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Пн \t Вт \t Ср \t Чт \t Пт \t Сб \t Вс \t");
            Console.ResetColor();
            while(dayNum < day) //сдвиг
            {
                Console.Write("\t ");
                temperature[i1, j1 + day-1] = temperature[i1, j1];
                temperature[i1, j1] = -10000;
                dayNum++;
                i1++;
                j1++;
            }
            dayNum = 1;
            for(int i = 0; i <= temperature.GetLength(0); i++)
            {
                for (; j < temperature.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{dayNum} ");
                    Console.ResetColor();
                    Console.Write($"{temperature[i,j]}\t ");
                    dayNum++; 
                    
                }
                j = 1;
                Console.WriteLine();
            }
            //Console.WriteLine(monthAr[month - 1]);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MatrixWeather weather;
            
            Console.Write("Конструктор по умолчанию - 1/ с вашими данными - 2");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                weather = new MatrixWeather();
                weather.Output();
            }
            if (input == 2)
            {
                Console.Write("Введите месяц: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Введите день: ");
                int day = int.Parse(Console.ReadLine());
                weather = new MatrixWeather(month, day);
                weather.Output();
            }
            
            Console.ReadKey();
        }
    }
}
