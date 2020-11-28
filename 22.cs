using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, p = 0, s = 1, sp = 0;
            int x;
            Console.WriteLine("Cititi cele trei numere reale de la tastatura: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam? Aria sau perimetrul? Pentru arie tastati 1,pentru perimetru tastati 2: ");
            x = int.Parse(Console.ReadLine());
            switch(x)
            {
                case 1:
                    sp = (a + b + c) / 2;
                    s = (float)Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
                    Console.WriteLine(s);
                    break;
                case 2:
                    p = a + b + c;
                    Console.WriteLine(p);
                    break;
            }
        }
    }
}
