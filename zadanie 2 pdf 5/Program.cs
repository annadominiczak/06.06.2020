using System;

namespace zadanie_2_pdf_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int y, x, Xa, Ya, Xb, Yb;

            Console.WriteLine("Prosze podać współrzędną x punktu a");
            Xa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prosze podać współrzędną y punktu a");
            Ya = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prosze podać współrzędną x punktu b");
            Xb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prosze podać współrzędną y punktu b");
            Yb = Convert.ToInt32(Console.ReadLine());


            //y = ax + b

            decimal a = (Ya - Yb) / (Xa - Xb);

            decimal b = Ya - ((Ya - Yb) / (Xa - Xb) * Xa);

            Console.WriteLine($"Prosta przechodząca przez podane 2 punkty ma postac y = {a}x + {b}");

            Console.ReadLine();
        }
    }
}