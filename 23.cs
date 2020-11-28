using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, ma = 0, nr = 0, s = 0;
            Console.WriteLine("Cititi primul numar: ");
            x = int.Parse(Console.ReadLine());
            while(x!=0)
            {
                s = s + x;
                nr++;
                x = int.Parse(Console.ReadLine());
            }
            ma = s / nr;
            Console.WriteLine(ma);
        }
    }
}
