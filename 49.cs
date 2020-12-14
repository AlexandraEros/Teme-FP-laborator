using System;

namespace _49
{
    class Program
    {
        public static int impare(int [] a,int n)
        {
            int i;
            for (i = 0; i <= n - 1; i++)
                if (a[i] % 2 == 0)
                    return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[100];
            Console.Write("Cate elemente contine vectorul? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului: ");
            for (i = 0; i <= n - 1; i++)
                a[i] = int.Parse(Console.ReadLine());
            if (impare(a, n) == 1)
                Console.WriteLine("Vectorul contine doar valori impare");
            else
                Console.WriteLine("Vectorul contine si valori pare");
        }
    }
}
