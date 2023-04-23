﻿using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a квадрата:");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Ошибка: введите положительное число");
            }
            CSquare square = new CSquare(a);
            Console.WriteLine($"Диагональ: {square.GetDiagonal()}\n" +
                $"Периметр: {square.GetPerimeter()}\n" +
                $"Площадь: {square.GetArea()}");

            Console.WriteLine("Введите a правильной пирамиды:");
            double a1;
            while (!double.TryParse(Console.ReadLine(), out a1) || a1 <= 0)
            {
                Console.WriteLine("Ошибка: введите положительное число");
            }
            Console.WriteLine("Введите h правильной пирамиды:");
            double h;
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Ошибка: введите положительное число");
            }
            CRPyramid pyramid = new CRPyramid(a1, h);
            Console.WriteLine($"Периметр основания: {pyramid.GetPerimeter()}\n" +
                $"Площадь основания: {pyramid.GetArea()}\n" +
                $"Радиус вписанной окружности: {pyramid.Getr()}\n" +
                $"Радиус описанной окружности: {pyramid.GetR()}\n" +
                $"Объем: {pyramid.GetVolume()}");

            Console.WriteLine("Задание а: введите N");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Ошибка: введите целое число больше 0");
            }
            CSquare[] SquareArr = new CSquare[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введите длину стороны {i + 1} квадрата:");
                double side;
                while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                {
                    Console.WriteLine("Ошибка: введите положительное число");
                }
                SquareArr[i] = new CSquare(side);
            }
            CSquare minSquare = SquareArr[0];
            for (int i = 1; i < N; i++)
            {
                if (SquareArr[i].GetArea() < minSquare.GetArea())
                {
                    minSquare = SquareArr[i];
                }
            }
            Console.WriteLine($"Наименьшая площадь: {minSquare.GetArea()}");

            Console.WriteLine("Задание б: введите M");
            double M;
            while (!double.TryParse(Console.ReadLine(), out M) || M <= 0)
            {
                Console.WriteLine("Ошибка: введите число > 0 ");
            }
            Console.WriteLine("Введите f");
            double f;
            while (!double.TryParse(Console.ReadLine(), out f) || f <= 0)
            {
                Console.WriteLine("Ошибка: введите положительную длину");
            }
            CRPyramid[] PyramidArr = new CRPyramid[(int)M];
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"Введите длину стороны правильной пирамиды {i + 1}");
                double aPyramid;
                while (!double.TryParse(Console.ReadLine(), out aPyramid) || aPyramid <= 0)
                {
                    Console.WriteLine("Ошибка: введите положительную длину");
                }
                Console.WriteLine($"Введите эпофему правильной пирамиды {i + 1}");
                double ePyramid;
                while (!double.TryParse(Console.ReadLine(), out ePyramid) || ePyramid <= 0)
                {
                    Console.WriteLine("Ошибка: введите положительную длину");
                }
                if (Math.Sqrt(ePyramid * ePyramid - Math.Pow((aPyramid / 2), 2)) > f)
                {
                    count++;
                }
            }
            Console.WriteLine($"Ответ:{count}шт");
            Console.ReadLine();

        }

        class CSquare
        {
            protected double a;
            public CSquare(double a)
            {
                this.a = a;
            }
            public double GetDiagonal()
            {
                return a * Math.Sqrt(2);
            }
            public double GetPerimeter()
            {
                return a * 4;
            }
            public double GetArea()
            {
                return a * a;
            }
        }
        class CRPyramid : CSquare
        {
            double h;
            public CRPyramid(double a, double h) : base(a)
            {
                this.h = h;
                this.a = a;
            }
            public new double GetArea()
            {
                return a * a * Math.Sqrt(3);
            }
            public double GetVolume()
            {
                return (h * a * a) / (4 * Math.Sqrt(3));
            }
            public new double GetPerimeter()
            {
                return a * 3;
            }
            public double GetR()
            {
                return (Math.Sqrt(3) / 3) * a;
            }
            public double Getr()
            {
                return (Math.Sqrt(3) / 6) * a;
            }
        }
    }
}
