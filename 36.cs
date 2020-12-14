using System;

namespace _36
{
    class Program
    {
        public int timp(int o1,int m1,int s1,int o2,int m2,int s2)
        {
            int t1 = 0, t2 = 0, diferenta;
            t1 = o1 * 3600 + m1 * 60 + s1;
            t2 = o2 * 3600 + m2 * 60 + s2;
            diferenta = t1 - t2;
            return diferenta;

        }
        static void Main(string[] args)
        {
            int o1, m1, s1, o2, m2, s2;
            Console.Write("o1=");
            o1 = int.Parse(Console.ReadLine());
            Console.Write("m1=");
            m1 = int.Parse(Console.ReadLine());
            Console.Write("s1=");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("o2=");
            o2 = int.Parse(Console.ReadLine());
            Console.Write("m2=");
            m2 = int.Parse(Console.ReadLine());
            Console.Write("s2=");
            s2 = int.Parse(Console.ReadLine());
            var t = new Program();
            Console.WriteLine(t.timp(o1,m1,s1,o2,m2,s2));
        }
    }
}
