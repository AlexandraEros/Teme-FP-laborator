using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, k, i, nr = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                i = int.Parse(Console.ReadLine());
                if (i % p == k)
                    nr++;
                n--;
            }
            Console.WriteLine(nr);
        }
    }
}
