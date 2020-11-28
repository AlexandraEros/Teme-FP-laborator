using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 1, d;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (d = 2; d <= n/2; d++)
                if (n % d == 0)
                    s = s + d;
            if (n == s)
                Console.WriteLine("n este numar perfect");
            else
                Console.WriteLine("n nu este numar perfect");
        }
    }
}
