using System;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите E: ");
            double eps = Convert.ToDouble(Console.ReadLine());
            double S = 0;
            double n = 1;
            while (Math.Abs(-Math.Pow(1.0, n - 1.0) / Math.Pow(n, 2.0)) >= eps)
            {
                S += -Math.Pow(1.0, n - 1.0) / Math.Pow(n, 2.0);
                n++;
            }
            Console.WriteLine($"Сумма ряда: {S}");
        }
    }
}
