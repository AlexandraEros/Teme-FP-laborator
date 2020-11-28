using System;

namespace _6
{
    class Program
    {
        public int Suma(int n)
        {
            int s = 0, d;
            for(d=1;d*d<=n;d++)
                if(n%d==0)
                {
                    s = s + d + n / d;
                    if (d == n / d)
                        s = s - d;
                }
            return s;
        }
        static void Main(string[] args)
        {
            int a, b, i, j;
            Console.Write("Introduceti cele 2 numere care reprezinta limitele intervalului: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Program x = new Program();
            for (i = a; i < b; i++)
                for (j = i + 1; j <= b; j++)
                    if (x.Suma(i) == x.Suma(j))
                        Console.WriteLine("{0} si {1} sunt prietene", i, j);
        }
    }
}
