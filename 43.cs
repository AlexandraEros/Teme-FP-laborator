using System;

namespace _43
{
    class Program
    {
        public int oglindit(int n)
            {
                int o = 0, cp = n;
                while(n!=0)
                {
                    o = o * 10 + n % 10;
                    n = n / 10;
                }
                if (o == cp)
                    return 1;
                else
                    return 0;
            }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            n = int.Parse(Console.ReadLine());
            var t = new Program();
            if (t.oglindit(n) == 1)
                Console.WriteLine("Numarul dat este palindrom");
            else
                Console.WriteLine("Numarul dat nu este palindrom");
        }
    }
}
