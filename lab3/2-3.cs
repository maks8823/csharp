using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите N");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            double a0 = 1;
            double a;
 
            for (int k = 1; k <= N; k++)
            {
                a = (a0 + 1) / k;
                a0 = a;
                Console.Write($"{Math.Round(a0, 3)} ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите N");
            int N1;
            while (!int.TryParse(Console.ReadLine(), out N1) || N1 <= 1)
            {
                Console.WriteLine("Ошибка");
            }
            int f1 = 1, f2 = 1, f = 0, r = 2;
 
            while (f < N1)
            {
                ++r;
                f = f2 + f1;
                f2 = f1;
                f1 = f;
            }
            if (f == N1)
            {
 
                Console.WriteLine($"k={r} ");
            }
            else
            {
                Console.WriteLine("Введенное число не является числом Фибоначчи");
            }
            Console.ReadLine();
        }
    }
}
