using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, x, s = 0, p;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            while (true)
            {
                i++;
                x = 1;
                for (p = 2; p <= i / 2; p++)
                    if (i % p == 0)
                        x = 0;
                if (x == 1)
                {
                    Console.Write(i + " ");
                    s++;
                    if (s == n)
                        break;
                }
            }
        }
    }
}
