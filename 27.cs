using System;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nrcifre = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                nrcifre++;
                n = n / 10;
            }
            Console.WriteLine("Numarul dat contine {0} cifre", nrcifre);
        }
    }
}
