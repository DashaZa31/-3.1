using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    class DateTim
    {
        public int hour;
        public int minute;
        public int second;

        public void Chasy()
        {
            DateTim dat1 = new DateTim();
            Console.WriteLine("Введите часы");
            dat1.hour = Convert.ToInt32(Console.ReadLine());

            int r;
            Console.WriteLine("На сколько часов меняем время?");
            r = Convert.ToInt32(Console.ReadLine());
            int H;
            H = dat1.hour + r;
            Console.WriteLine(H + ":00:00");

        }


        public void Minuti()
        {
            DateTim dat1 = new DateTim();
            Console.WriteLine("Введите минуты");
            dat1.minute = Convert.ToInt32(Console.ReadLine());
            int t;
            Console.WriteLine("На сколько минут меняем время?");
            t = Convert.ToInt32(Console.ReadLine());
            int M;
            M = dat1.minute + t;
            Console.WriteLine("00:" + M + ":00");

        }

        public void Secundi()
        {
            DateTim dat1 = new DateTim();
            Console.WriteLine("Введите секунды");
            dat1.second = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("На сколько секунд меняем время?");
            y = Convert.ToInt32(Console.ReadLine());
            int S;
            S = dat1.second + y;
            Console.WriteLine("00:00:" + S);

        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            DateTim dat1 = new DateTim();
            Console.WriteLine("Какое действие выполнить?\n 1.Вывести текущее время\n 2.Ввод времени\n 3.Меняем часы\n 4.Меняем минуты\n 5.Меняем секунды");
            Console.Write("Введите цифру: ");
            try
            {
                int s = Convert.ToInt32(Console.ReadLine());

                switch (s)
                {
                    case 1:
                        String Time = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine(Time);

                        break;
                    case 2:

                        int H1;
                        Console.WriteLine("Введите часы (от 0 до 23)");
                        H1 = Convert.ToInt32(Console.ReadLine());
                        int M1;
                        Console.WriteLine("Введите минуты (от 0 до 59)");
                        M1 = Convert.ToInt32(Console.ReadLine());
                        int S1;
                        Console.WriteLine("Введите секунды");
                        S1 = Convert.ToInt32(Console.ReadLine());
                        if (H1 <= 24 && M1 <= 59 && S1 <= 59)
                            Console.WriteLine("Введенное время - " + H1 + ":" + M1 + ":" + S1);
                        else
                            Console.WriteLine("Введено недопустимое значение");

                        break;
                    case 3:
                        dat1.Chasy();
                        break;
                    case 4:
                        dat1.Minuti();
                        break;
                    case 5:
                        dat1.Secundi();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен не верный формат. Введите цифру 1,2,3,4 или 5");
            }
        }
    }
}

