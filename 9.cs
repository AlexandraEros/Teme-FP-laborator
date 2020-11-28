using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, d, s = 0, k = 0, sh = 0, p = 1, ma, mg, mh;
            Console.Write("Introduceti de la tastatura valoarea lui a: ");
            a = int.Parse(Console.ReadLine());
            for(d=2;d<=a/2;d++)
            {
                if(a%d==0)
                {
                    k++;
                    s = s + d;
                    sh = sh + 1 / d;
                    p = p * d;
                }
            }
            ma = s / k;
            mg = Math.Pow(p, 1.0 / k);
            mh = k / sh;
            Console.WriteLine("Media aritmetica a divizorilor lui a este {0}", ma);
            Console.WriteLine("Media geometrica a divizorilor lui a este {0}", mg);
            Console.WriteLine("Media armonica a divizorilor lui a este {0}", mh);
        }
    }
}
