using System;

namespace zadanie_8_liczba_pierwsza
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Prosze podać liczbę");
            n = Convert.ToInt32(Console.ReadLine());
            i = 2;

            bool isPrime = true;

            while (i < n)

            {
                if (n % i == 0) 

                {
                    isPrime = false;
                }

                i++;
            }

            Console.WriteLine($"Liczba jest pierwsza: {isPrime}");
            Console.ReadLine();
        }
    }
}
