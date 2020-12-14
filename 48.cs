using System;
namespace _48
{
    class Program
    {
        private static int minim(int[] a, int n)
        {
            int min, i;
            min = a[0];
            for (i = 1; i <= n - 1; i++)
                if (a[i] < min) min = a[i];
            return min;
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
            Console.WriteLine("Minimul este {0}", minim(v, n));
        }
    }
}