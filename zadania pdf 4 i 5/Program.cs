using System;

namespace zadania_pdf_4_i_5
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            int n, i, b, silnia;
            Console.WriteLine("Prosze podać liczbę");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            silnia = 1;

            while (i <= n)
            {
                silnia *= i;

                i++;
            }
            Console.WriteLine($"Silnia {n}!={silnia}");
            Console.ReadLine();
        }
    }
}