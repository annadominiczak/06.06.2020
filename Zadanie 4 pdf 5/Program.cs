using System;

namespace Zadanie_4_pdf_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podać kwote w PLN");
            double pln = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz na jaką walutę przekonwertować.");
            Console.WriteLine("Wpisz 1 jeśli na funty.");
            Console.WriteLine("Wpisz 2 jeśli na dolary.");
            Console.WriteLine("Wpisz 3 jeśli na euro.");
            int currencyToConvert = int.Parse(Console.ReadLine());

            switch (currencyToConvert)
            {
                case 1:
                    Console.WriteLine($"{pln * 0.2} funtów");
                    break;
                case 2:
                    Console.WriteLine($"{pln * 0.25} dolarów");
                    break;
                case 3:
                    Console.WriteLine($"{pln * 0.23} euro");
                    break;
                default:
                    Console.WriteLine("Nierozponano liczby");
                    break;
            }

        }
    }
}
