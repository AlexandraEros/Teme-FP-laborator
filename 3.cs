using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, p, q = 1;
            Console.Write("Citeste 3 mumere de la tastatura:");
            i = int.Parse(Console.ReadLine());
            j= int.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine());
            for (p = 1; p <= j; p++)
                q = q * i;
            Console.WriteLine("Restul impartirii este: {0} ",q % k);
        }
    }
}
