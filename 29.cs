using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, ok;
            Console.WriteLine("Introduceti valoarea lui m");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Numerele prime mai mici sau egale cu {0} sunt: ", m);
            for (i = 2; i <= m; i++)
            {
                ok = 0;
                for (j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0) ok = 1;
                }
                if (ok == 0) Console.WriteLine("{0}", i);
            }
        }
    }
}
