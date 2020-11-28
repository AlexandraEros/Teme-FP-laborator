using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            double  n, p = 1, i;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine(1);
            else
            {
                for (i = 1; i <= n; i++)
                    p = p * i;
                Console.WriteLine(p);
            }
        }
    }
}
