using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random x = new Random();
            int n = x.Next(0, 16);
            int n1 = x.Next(0, 16);
            if (n == n1)
            {
                n1++;
                n1 = n1 % 16;
            }
            Console.ForegroundColor = (ConsoleColor)n;
            Console.BackgroundColor = (ConsoleColor)n1;
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(50, 50);
            Console.Beep();
            if (Console.CapsLock)
            {
                Console.WriteLine("CapsLock активен");
            }
            else
            {
                Console.WriteLine("CapsLock неактивен");
            }
            if (Console.NumberLock)
            {
                Console.WriteLine("NumLock активен");
            }
            else
            {
                Console.WriteLine("NumLock неактивен");
            }
            Console.WriteLine("Введите имя");
            string a = Console.ReadLine();
            Console.Title = $"{a}";
            Console.WriteLine("Введите фамилию");
            string b = Console.ReadLine();
            Console.WriteLine($"Привет {a + ' ' + b}");
            Console.WriteLine("Введите длину ребра куба");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"V= {c * c * c}");
            Console.WriteLine($"S= {6 * c * c}");
            Console.WriteLine("Введите трехзначное число");
            int d = Convert.ToInt32(Console.ReadLine());
            int f = d;
            
            while (d > 9)
            {
                d /= 10;
            }
            Console.WriteLine($"Первая цифра {d}");
            Console.WriteLine($"Последняя цифра {f % 10}");
            Console.ReadKey();
        }
    }
}
