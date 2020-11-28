using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, i, cp;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for(i=5;i<=n;i++)
            {
                cp = i;
                s = 0;
                while(cp!=0)
                {
                    s = s + cp%10;
                    cp = cp / 10;
                }
                if (s % 5 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
