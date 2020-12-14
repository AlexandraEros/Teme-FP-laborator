using System;

namespace _39
{
    class Program
    {
        public int cub(int n)
        {
            int r;
            r = (int)Math.Cbrt(n);
            if (r * r * r == n)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            var t = new Program();
            if (t.cub(n) == 1)
                Console.WriteLine("Numarul dat este cub perfect");
            else
                Console.WriteLine("Numarul dat nu este cub perfect");
        }
    }
}
