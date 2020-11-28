using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            for(f=0;f<=300;f++)
            {
                c = (f - 32) / 1.8;
                c = Math.Round(c,2);
                Console.WriteLine("Temperatura in grade Fahrenheit este {0},iar in grade Celsius este {1}", f, c); ;
            }
        }
    }
}
