using System;

namespace Фоновая4._1
{
    internal class MatrixWeather
    {
        private static Random rnd = new Random();

        public enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        public int[] monthAr = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int month;
        private int day;
        private int[,] temperature;

        public MatrixWeather()
        {
            month = 1;
            day = 1;
            temperature = new int[6, 7];
            GenTemp(month, temperature, monthAr);
        }

        public MatrixWeather(int month, int day)
        {
            this.month = month;
            this.day = day;
            temperature = new int[6, 7];
            GetDay = day;
            GenTemp(month, temperature, monthAr);
        }

        private static int[,] GenTemp(int month, int[,] diary, int[] days)
        {
            int tempJ = days[month - 1];
            int count = 0;
            for (int i = 0; i < diary.GetLength(0); i++)
                for (int j = 0; j < diary.GetLength(1); j++, count++)
                {
                    if (count >= tempJ) { diary[i, j] = -1000; }
                    else
                    {
                        switch (month)
                        {
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
                }
            return diary;
        }

        public int GetMonth
        {
            get
            {
                return month;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 12) throw new Exception("ОШИБКА: Месяц больше 12 или меньше 0!");
                    if (value == month) throw new Exception("ОШИБКА: новый месяц равен текущему!");
                    else
                    {
                        month = value;
                        GenTemp(month, temperature, monthAr);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        public int GetDay
        {
            get
            {
                return day;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 7) throw new Exception("ОШИБКА: Месяц больше 7 или меньше 0!");
                    else
                    {
                        if (value < day)
                        {
                            day = value - 1;

                            for (int z = 0; z < day; z++)
                            {
                                for (int i = 0; i < temperature.GetLength(0); i++)
                                {
                                    if (i != 0) temperature[i - 1, temperature.GetLength(1) - 1] = temperature[i, 0];
                                    for (int j = 0; j < temperature.GetLength(0); j++)
                                        temperature[i, j] = temperature[i, j + 1];
                                }
                            }
                        }
                        if (value > day)
                        {
                            day = value - 1;
                            for (int z = 0; z < day; z++)
                            {
                                int temp1 = temperature[0, temperature.GetLength(1) - 1], temp2;
                                for (int i = 0; i < temperature.GetLength(0); i++)
                                {
                                    temp2 = temperature[i, temperature.GetLength(1) - 1];
                                    for (int j = temperature.GetLength(0); j > 0; j--)
                                    {
                                        temperature[i, j] = temperature[i, j - 1];
                                    }
                                    if (i == 0) temperature[0, 0] = -1000;
                                    else
                                    {
                                        temperature[i, 0] = temp1;
                                    }
                                    temp1 = temp2;
                                }
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        public int GetNumOfDays
        {
            get { return monthAr[month - 1]; }
        }

        public int WhenTempEqualsZero
        {
            get
            {
                int k = 0;
                foreach (int i in temperature)
                    if (i == 0) k++;
                return k;
            }
        }

        public int MaxTempDiff()
        {
            int max = int.MinValue;
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1) - 1; j++)
                {
                    if (temperature[i, j + 1] == -1000) break;
                    if (Math.Abs(temperature[i, j] - temperature[i, j + 1]) > max) max = Math.Abs(temperature[i, j] - temperature[i, j + 1]);
                }
            }
            return max;
        }

        public void MaxTempDiff(out int maxDay, out int temp, out int maxTemp)
        {
            temp = 0; maxDay = 0;
            int count = 0, max = int.MinValue, t;

            for (int i = 0; i < temperature.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < temperature.GetLength(1) - 1; j++)
                {
                    t = temperature[i, 6];
                    if (temperature[i, j + 1] == -1000) { break; }
                    if (Math.Abs(temperature[i, j] - temperature[i, j + 1]) > max)
                    {
                        max = Math.Abs(temperature[i, j] - temperature[i, j + 1]);
                        maxDay = count + 2;
                        temp = temperature[i, j];
                    }
                    if (Math.Abs(t - temperature[i + 1, 0]) > max)
                    {
                        max = Math.Abs(t - temperature[i, j]);
                        maxDay = count + 2;
                        temp = t;
                    }
                    count++;
                }
            }
            maxTemp = max;
        }

        public void Output()
        {
            foreach (int i in temperature) Console.Write(i + " ");
            Console.WriteLine((Months)Enum.GetValues(typeof(Months)).GetValue(month - 1));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Пн \t Вт \t Ср \t Чт \t Пт \t Сб \t Вс \t");
            Console.ResetColor();
            Console.WriteLine(day);
            int count = 1, j = day - 1;
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (; j < temperature.GetLength(1); j++)
                {
                    if (temperature[i, j] == -1000) Console.Write("   \t ");
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" " + count);
                        Console.ResetColor();
                        Console.Write(" " + temperature[i, j] + "\t");
                        count++;
                    }
                }
                j = 0;
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MatrixWeather weather;
            Console.Write("Конструктор по умолчанию - 1/ с вашими данными - 2: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 2)
            {
                Console.Write("Введите месяц: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Введите день: ");
                int day = int.Parse(Console.ReadLine());
                weather = new MatrixWeather(month, day);
                weather.GetDay = day;
            }
            else
            {
                weather = new MatrixWeather();
            }
            weather.Output();

            Console.WriteLine("Хотите изменить: 1 - день, 2 - месяц");
            Console.Write("Хотите посмотреть: 3 - самый большой скачок температуры, 4 - номер дня когда это произошло и температуру в этот день, 5 - кол-во дней в дневнике, 6 - кол-во дней, когда t = 0: ");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("Введите новый день: ");
                weather.GetDay = int.Parse(Console.ReadLine());
                weather.Output();
            }
            if (input == 2)
            {
                Console.Write("Введите новый месяц: ");
                weather.GetMonth = int.Parse(Console.ReadLine());
                weather.Output();
            }
            if (input == 3) Console.WriteLine($"Скачок: {weather.MaxTempDiff()}");
            if (input == 4)
            {
                weather.MaxTempDiff(out int maxDay, out int temp, out int maxTemp);
                Console.WriteLine($"День: {maxDay}, температура: {temp}, скачок: {maxTemp}");
            }
            if (input == 5) Console.WriteLine($"Кол-во дней: {weather.GetNumOfDays}");
            if (input == 6) Console.WriteLine($"Эти дни: {weather.WhenTempEqualsZero}");
            Console.ReadKey();
        }
    }
}