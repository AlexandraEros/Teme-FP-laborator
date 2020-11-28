using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, minim, maxim;
            Console.WriteLine("Introduceti de la tastatura primul numar citit: ");
            n = int.Parse(Console.ReadLine());
            minim = maxim = n;
            while(n!=0)
            {
                if (n < minim)
                    minim = n;
                if (n > maxim)
                    maxim = n;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Minimul si maximul dintre numerele citite sunt: {0} si {1}", minim, maxim);

        }
    }
}
