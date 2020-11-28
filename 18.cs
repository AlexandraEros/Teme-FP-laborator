using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            double lungime_cerc, raza, pi = 3.14;
            Console.Write("Introduceti raza cercului: ");
            raza = double.Parse(Console.ReadLine());
            lungime_cerc = 2 * pi * raza;
            Console.WriteLine("Lungimea cercului este: {0} ", lungime_cerc);
        }
    }
}
