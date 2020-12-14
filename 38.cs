using System;

namespace _38
{
    class Program
    {
        public int lucrare(int n,int m)
        {
            int nr_zile;
            nr_zile = n/m;
            return nr_zile;
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Cate zile ii ia muncitorului sa termine lucrarea?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cati muncitori contine echipa?");
            m = int.Parse(Console.ReadLine());
            var t = new Program();
            Console.WriteLine(t.lucrare(n, m));
        }
    }
}
