using System;

namespace _42
{
    class Program
    {
        private static void inversare(int[] a, int[] b, int n)
        {
            int i;
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\nVectorul b este:");
            for (i = 0; i <= n - 1; i++)
            {
                b[i] = a[n - 1 - i];
                Console.Write("b[{0}]={1} ", i, b[i]);
            }
        }
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            int[] b = new int[100];
            Console.WriteLine("Dati nr de elemente de initializat");
            n = int.Parse(Console.ReadLine());
            inversare(a, b, n);
        }
    }
}
