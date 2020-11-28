using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, p = 1; 
            Console.Write("Introduceti numarul de foi: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de randuri: ");
            r = int.Parse(Console.ReadLine());
            p = n * r;
            Console.WriteLine("Cartea are {0} de randuri",p);
        }
    }
}
