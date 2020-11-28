using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double cel, fah;
            Console.Write("Introduceti 1 pentru transformare din grade Celsius,altfel introduceti 2: ");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1: //convertirea din grade celsius
                    Console.Write("Temperatura in grade Celsius este:");
                    cel = double.Parse(Console.ReadLine()); 
                    fah = cel * 1.8 + 32;
                    Console.WriteLine("Temperatura in grade Fahrenheit este: {0} ", fah);
                    break;
                case 2: //convertirea din grade fahrenheit
                    Console.Write("Temperatura in grade Fahrenheit este:");
                    fah = double.Parse(Console.ReadLine());
                    cel = (fah - 32) * 5 / 9;
                    Console.WriteLine("Temperatura in grade Celsius este: {0} ", cel);
                    break;
            }
        }
    }
}
