using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, ma = 0, mg = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa calculam? Media aritmetica (1) sau geometrica (2)?");
            x = int.Parse(Console.ReadLine());
            switch(x)
            {
                case 1:
                    if (a > 0 && b > 0)
                    {
                        ma = (a + b) / 2;
                        Console.WriteLine(ma);
                    }
                    else
                        Console.WriteLine("Eroare!");
                    break;
                case 2:
                    if (a > 0 && b > 0)
                    {
                        mg = Math.Sqrt(a * b);
                        Console.WriteLine(mg);
                    }
                    else
                        Console.WriteLine("Eroare!");
                    break;
                default:
                    Console.Beep(5000,1000);
                    break;
            }
        }
    }
}
