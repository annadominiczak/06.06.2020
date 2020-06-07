using System;

namespace Zadanie_5_pdf_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podać n");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            decimal toReturn = n;
            while (i < n)
            {
                toReturn *= n;
                i++;
            }

            Console.WriteLine($"N do potegi n wynosi: {toReturn}");
        }
    }
}
