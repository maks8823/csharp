using System;
 
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int n = 18;
            var arr = new double[n];
            double MIN_VALUE = -10.0;
            double MAX_VALUE = 10.0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Round(random.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE, 2);
            }
            Console.WriteLine("Массив F");
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[j] +" ") ;
            }
            Console.WriteLine();
            var arr1 = new double[n];
            for (int k = 0; k < n; k++)
            {
                arr1[k] = Math.Round((0.13 * Math.Pow(arr[k],3))-2.5*arr[k]+8,2);
            }
            Console.WriteLine("Массив P");
            for (int r = 0; r < n; r++)
            {
                Console.Write(arr1[r] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Отрицательные элементы массива P");
            for (int e = 0; e < n; e++)
            {
                if (arr1[e]<0)
                {
                    Console.Write(arr1[e] + " ");
                }
 
            }
            Console.WriteLine();
 
        }
    }
}
