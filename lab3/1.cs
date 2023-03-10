using System;

namespace lab3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double a = 0, r1 = 0, r2 = 0, s = 0;
            Console.WriteLine("Введите номер 1-4");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > 4)
            {
                Console.WriteLine("Ошибка");
            }
            switch (N)
            {
                case 1:
                    Console.WriteLine("Введите длинну стороны а");
                    while (!double.TryParse(Console.ReadLine(), out a) || a < 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    r1 = a * (Math.Sqrt(3)) / 6;
                    r2 = 2 * r1;
                    s = (a * a) * (Math.Sqrt(3)) / 6;
                    break;

                case 2:
                    Console.WriteLine("Введите радиус R1 вписанной окружности");
                    while (!double.TryParse(Console.ReadLine(), out r1) || r1 < 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    a = r1 / (Math.Sqrt(3) / 6);
                    r2 = 2 * r1;
                    s = (a * a) * (Math.Sqrt(3)) / 6;
                    break;

                case 3:
                    Console.WriteLine("Введите радиус R2 описанной окружности");
                    while (!double.TryParse(Console.ReadLine(), out r2) || r2 < 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    a = (r2 / 2) / (Math.Sqrt(3) / 6);
                    r1 = r2 / 2;
                    s = (a * a) * (Math.Sqrt(3)) / 6;
                    break;

                case 4:
                    Console.WriteLine("Введите площадь S");
                    while (!double.TryParse(Console.ReadLine(), out s) || s < 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    a = Math.Sqrt(s / (Math.Sqrt(3) / 4));
                    r1 = a * (Math.Sqrt(3)) / 6;
                    r2 = 2 * r1;
                    break;
            }
            Console.WriteLine($"1.a: {a}");
            Console.WriteLine($"2.r1: {r1}");
            Console.WriteLine($"3.r2: {r2}");
            Console.WriteLine($"4.s: {s}");

        }
    }
}
