using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, o = 0, cn;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            cn = n; //cn este copia lui n
            while(n!=0)
            {
                o = o * 10 + n % 10; //calculam oglinditul lui n
                n = n / 10;
            }
            if (cn == o)
                Console.WriteLine("Numarul dat este palindrom");
            else
                Console.WriteLine("Numarul dat nu este palindrom");
        }
    }
}
