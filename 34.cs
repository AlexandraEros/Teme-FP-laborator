using System;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, ok;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                ok = 0;
                for (j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0) ok = 1;
                }
                if (ok == 0) Console.WriteLine("{0}", i);
            }

        }
    }
}
