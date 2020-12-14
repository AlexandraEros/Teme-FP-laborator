using System;

namespace _51
{
    class Program
    {
        public static int raport(int [] a,int n)
        {
            int i, nrpare = 0, nrimpare = 0, raport;
            for(i=0;i<=n-1;i++)
            {
                if (a[i] % 2 == 0)
                    nrpare++;
                else
                    nrimpare++;
            }
            raport = nrpare / nrimpare;
            return raport;
        }
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[100];
            Console.WriteLine("Cate elemente contine vectorul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (i = 0; i <= n - 1; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Raportul dintre numarul elementelor pare si celor impare din vector este:");
            Console.WriteLine(raport(a, n));
        }
    }
}
