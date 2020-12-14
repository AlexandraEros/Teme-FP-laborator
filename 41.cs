using System;
namespace _41
{
    class Test
    {

        public void tabla_inmultirii(int n)
        {
            int i, p;
            for (i = 0; i <= 10; i++)
            {
                p = 1;
                p = n * i;
                Console.WriteLine("{0}*{1}={2}", n, i, p);
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            var t = new Test();
            t.tabla_inmultirii(n);
        }
    }
}
