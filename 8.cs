using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i, rez, p1=1, p2=1, p3=1;
            Console.WriteLine("Introduceti doua numere de la tastatura: ");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                p1 = p1 * i;
            for (i = 1; i <= k; i++)
                p2 = p2 * i;
            for (i = 1; i <= n - k; i++)
                p3 = p3 * i;
            rez = p1 / (p2 * p3);
            Console.WriteLine("Rezultatul este: {0}",rez);
        }
    }
}
