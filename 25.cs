using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, p = 0, i;
            Console.WriteLine("Introduceti de la tastatura doua numere naturale: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (i = 1; i <= b; i++)
                p = p + a;
            Console.WriteLine("Produsul celor doua numere este {0}", p);
        }
    }
}
