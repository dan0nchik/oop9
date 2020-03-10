using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая4._1
{
    public enum Months{
        Январь = 31,
        Февраль = 29,
        Март = 31,
        Апрель = 30,
        Май = 31,
        Июнь =  30,
        Июль = 31,
        Август = 31,
        Сентябрь = 30,
        Октябрь = 31,
        Ноябрь = 30,
        Декабрь = 31
    }
    class MatrixWether {
        private Months month;
        private int day;
        int[,] temperature;
        public MatrixWether()
        {
            month = (Months)1;
            day = 1;
        }
        public MatrixWether(int month, int day)
        {
            this.month = (Months)month;
            this.day = day;
            if(day != 1)
            {
                temperature = new int[5, 7];
            }
        }
        
     


    }

    class Program
    {
        static void Main(string[] args)
        {
            MatrixWether weather;
            Console.Write("Конструктор по умолчанию - 1/ с вашими данными - 2");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                weather = new MatrixWether();
            }
            if (input == 2)
            {
                Console.Write("Введите месяц: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Введите день: ");
                int day = int.Parse(Console.ReadLine());
                weather = new MatrixWether(month, day);
            }
        }
    }
}
