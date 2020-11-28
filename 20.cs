using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, x, t, x0, t0;
            Console.Write("Introduceti valorile pentru distanta initiala,timpul initial,momentul t si distanta de la momentul t: ");
            x0 = int.Parse(Console.ReadLine());
            t0 = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            v = (x - x0) / (t - t0);
            Console.WriteLine(v);
        }
    }
}
