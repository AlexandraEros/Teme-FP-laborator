using System;

namespace _40
{
    class Program
    {
        private static void patrat(int[] a, int n)
        {
            int i;
            for (i = 0; i <= n - 1; i++)
                a[i] = a[i] * a[i];
        }

        static void Main(string[] args)
        {
            int n, i;
            int[] v = new int[100];
            Console.WriteLine("Dati nr de elem de initializat");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            patrat(v, n);
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine("{0}", v[i]);
        }
    }
}
