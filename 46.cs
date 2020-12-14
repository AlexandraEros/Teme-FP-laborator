using System;
namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, c, s;
            int[] a = new int[100];
            float med;
            Console.WriteLine("Dati nr de elemente de initializat din vector");
           
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Introduceti al {0}-lea nr",
               i);
                a[i] = int.Parse(Console.ReadLine());
            }
            /*Afisare elemente vector pe aceeasi linie*/
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
            s = c = 0;
            for (i = 0; i <= n - 1; i++)
                if (a[i] % 2 == 0)
                {
                    c++;
                    s = s + a[i];
                }
            med = (float)s / (float)c;

            Console.WriteLine("\nSuma={0}\nContor={1}\nMedia={2}", s, c,
            med);
        }
    }
}
