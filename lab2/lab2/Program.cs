using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int N;
            Console.WriteLine("Введите трехзначное число");
            N = Convert.ToInt32(Console.ReadLine());
            if ((N < 100 || N > 999))
            {
                while (true)
                {
                    Console.WriteLine("Введите трехзначное число");
                    N = Convert.ToInt32(Console.ReadLine());
                    if (N >= 100 && N <= 999)
                    {
                        break;
                    }
                }
            }
            int a = 0, b = 0, c = 0;
            a = N / 100;
            b = N / 10 - a * 10;
            c = N - b * 10 - a * 100;
            int minValue = Math.Min(Math.Min(a, b), c);
            int maxValue = Math.Max(Math.Max(a, b), c);
            int middleValue = a + b + c - minValue - maxValue;
            Console.WriteLine("Отсортированные цифры");
            a = minValue;
            b = middleValue;
            c = maxValue;
            Console.WriteLine(a + "" + b + "" + c);
            if ((b - a) == (c - b))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            */
            int N;
            Console.WriteLine("Введите трехзначное число");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 100 || N > 999)
            {
                Console.WriteLine("Ошибка: введите трехзначное число");
            }

            int[] digits = new int[3];
            for (int i = 0; i < 3; i++)
            {
                digits[i] = N % 10;
                N /= 10;
            }

            Array.Sort(digits);
            Console.WriteLine($"Отсортированные цифры: {digits[0]}{digits[1]}{digits[2]}");

            bool isArithmetic = (digits[2] - digits[1]) == (digits[1] - digits[0]);
            Console.WriteLine(isArithmetic ? "True" : "False");
            Console.WriteLine("Введите координаты трёх вершин прямоугольника в виде x1,y1,x2,y2,x3,y3");
            string input = Console.ReadLine();
            // Разбить входную строку на подстроки по пробелам и преобразовать каждую подстроку в целое число
            string[] coordinates = input.Split(' ');
            int x1 = int.Parse(coordinates[0]);
            int y1 = int.Parse(coordinates[1]);
            int x2 = int.Parse(coordinates[2]);
            int y2 = int.Parse(coordinates[3]);
            int x3 = int.Parse(coordinates[4]);
            int y3 = int.Parse(coordinates[5]);
            int x4, y4; // координаты четвертой вершины

            // найдем координаты четвертой вершины
            if (x1 == x2) 
            {
                x4 = x3; 
                y4 = y1 == y3 ? y2 : y1; 
            }
            else if (x1 == x3) 
            {
                x4 = x2; 
                y4 = y1 == y2 ? y3 : y1; 
            }
            else
            {
                x4 = x1; 
                y4 = y2 == y1 ? y3 : y2; 
            }
            Console.WriteLine($"Координаты четвертой вершины: ({x4},{y4})");
            Console.Write("Введите вещественное число a: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число b: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число c: ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число Xначальное: ");
            double firstx = Convert.ToDouble(Console.ReadLine());
            double secondx;
            Console.WriteLine("Введите вещественное число Xконечное: ");
            while (!double.TryParse(Console.ReadLine(), out secondx) || secondx<firstx)
            {
                Console.WriteLine("Ошибка");
            }
            double dx;
            Console.WriteLine("Введите вещественное число deltax: ");
            while (!double.TryParse(Console.ReadLine(), out dx) || dx < 0)
            {
                Console.WriteLine("dx должен быть > 0");
            }
            Console.WriteLine($"Введенные переменные (a={a1} b={b1} c={c1})");
            double fx;
            for (double x = firstx; x <= secondx; x += dx)
            {
                int v;
                if (c1 < 0 && x != 0)
                {
                    v = 1;
                    fx = -a1 * x - c1;
                }
                else if (c1 > 0 && x == 0)
                {
                    v = 2;
                    fx = (x - a1) / (-c1);
                }
                else
                {
                    v = 3;
                    if (c1 == a1)
                    {
                        Console.WriteLine("Некорректное значение c!");
                        continue;
                    }
                    fx = b1 * x / (c1 - a1);
                }
               
                Console.WriteLine($"x={Math.Round(x, 2)} f(x)={Math.Round(fx,2)} V={v}");
                
            }
            Console.ReadLine();
        }
    }
}
