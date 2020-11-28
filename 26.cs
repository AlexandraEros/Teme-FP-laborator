using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, contor=0, c2, r2, a1;
            Console.WriteLine("Introduceti doua numere de la tastatura: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a1 = a;
            do
            {
                a = a - b;
                contor++;
            }
            while (a >= b);
            c2 = contor;
            r2 = a;
            Console.WriteLine("Catul1 este {0}", a1 / b);
            Console.WriteLine("Restul1 este {0}", a1 % b);
            Console.WriteLine("Catul2 este {0}", c2);
            Console.WriteLine("Restul2 este {0}", r2);

        }
    }
}
