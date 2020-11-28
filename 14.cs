using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            for(c=-50;c<=1000;c++)
            {
                f = c * 1.8 + 32;
                f = Math.Round(f, 2);
                Console.WriteLine("Temperatura in grade Celsius este {0},iar in grade Fahrenheit este {1}", c, f); ;
            }
        }
    }
}
