using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, s, d;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            for(i=a;i<=b;i++)
            {
                s = 0;
                for (d = 1; d <= i / 2; d++)
                    if (i % d == 0)
                        s = s + d;
                if (s == i)
                    Console.WriteLine(i);
            }
        }
    }
}
