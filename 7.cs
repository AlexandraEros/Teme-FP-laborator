using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1=1, f2=1, f3, n, i;
            Console.Write("Introduceti un numar n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            if(n>1)
            {
                Console.WriteLine(f2);
                for(i=3;i<=n;i++)
                {
                    f3 = f1 + f2;
                    Console.WriteLine(f3);
                    f1 = f2;
                    f2 = f3;
                }
            }
        }
    }
}
