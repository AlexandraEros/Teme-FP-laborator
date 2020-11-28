using System;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int ok, n, b, p = 1, nr = 0, r, c;
            Console.Write("Introduceti 1 pentru transformare din baza 10 in alta baza,altfel introduceti 2: ");
            ok = int.Parse(Console.ReadLine());
            switch(ok)
            {
                case 1:
                    Console.Write("Introduceti numarul pe care doriti sa il convertiti si baza dorita: ");
                    n = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    while(n!=0)
                    {
                        r = n % b;
                        n = n / b;
                        nr = nr + r * p;
                        p = p * 10;
                    }
                    Console.WriteLine(nr);
                    break;
                case 2:
                    Console.Write("Introduceti numarul oe care doriti sa il convertiti in baza 10: ");
                    n = int.Parse(Console.ReadLine());
                    b = 10;
                    while(n!=0)
                    {
                        c = n % 10;
                        n = n / 10;
                        nr = nr + c * p;
                        p = p * b;
                    }
                    Console.WriteLine(nr);
                    break;
            }
        }
    }
}
