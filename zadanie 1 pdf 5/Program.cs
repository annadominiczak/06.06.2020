using System;

namespace zadanie_1_pdf_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Prosze podać liczbę x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prosze podać liczbę y");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)

            {
                Console.WriteLine($"Punkt {x},{y} nalezy do pierwszej cwiartki");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Punkt {x},{y} nalezy do drugiej cwiartki");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Punkt {x},{y} nalezy do trzeciej cwiartki");
            }
            else

            {
                Console.WriteLine($"Punkt {x},{y} nalezy do czwartej cwiartki");
            }

            Console.ReadLine();
        }
    }
}