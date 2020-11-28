using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r, ca, cb, cmmdc, cmmmc; 
            //ca si cb reprezinta copii ale lui a si b
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            ca = a;
            cb = b;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            cmmdc = a;
            cmmmc = ca * cb / cmmdc;
            Console.WriteLine("Cel mai mare divizor comun al celor doua numere este {0}", cmmdc);
            Console.WriteLine("Cel mai mic multiplu comun al celor doua numere este {0}", cmmmc);
        }
    }
}
