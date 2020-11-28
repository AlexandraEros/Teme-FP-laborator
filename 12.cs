using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            if (a == 1) //doua numere sunt prime intre ele daca cel mai mare divizor comun al lor este 1
                Console.WriteLine("Cele doua numere sunt prime intre ele");
            else
                Console.WriteLine("Cele doua numere nu sunt prime intre ele");
        }
    }
}
