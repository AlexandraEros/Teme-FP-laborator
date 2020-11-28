using System;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, b, rez;
            Console.WriteLine(" 1=adunare (+) ");
            Console.WriteLine(" 2=scadere (-) ");
            Console.WriteLine(" 3=inmultire (*) ");
            Console.WriteLine(" 4=impartire (/) ");
            Console.WriteLine(" 5=radical ");
            Console.WriteLine(" 6=modul ");
            Console.WriteLine("Introduceti un numar intre 1 si 6 in functie de operatia dorita: ");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    rez = a + b;
                    Console.WriteLine("Suma numerelor este: {0} ", rez);
                    break;
                case 2:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    rez = a - b;
                    Console.WriteLine("Diferenta numerelor este: {0} ", rez);
                    break;
                case 3:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    rez = a * b;
                    Console.WriteLine("Produsul numerelor este: {0} ", rez);
                    break;
                case 4:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    rez = a / b;
                    Console.WriteLine("Catul numerelor este: {0} ", rez);
                    break;
                case 5:
                    a = double.Parse(Console.ReadLine());
                    rez = Math.Sqrt(a);
                    Console.WriteLine("Radical din numarul dat este: {0} ", rez);
                    break;
                case 6:
                    a = double.Parse(Console.ReadLine());
                    if (a < 0)
                        rez = a * (-1);
                    else
                        rez = a;
                    Console.WriteLine("Modulul numarului dat este: {0} ", rez);
                    break;
                default:
                    Console.WriteLine("A fost introdus un numar gresit");
                    break;
            }

        }
    }
}
