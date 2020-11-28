using System;

namespace _31
{
    class Program
    {
        public int Prim(int n)
        {
            int d;
            if (n < 2)
                return 0;
            if (n == 2)
                return 1;
            if (n % 2 == 0)
                return 0;
            for (d = 3; d * d <= n; d=d+2)
                if (n % d == 0)
                    return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            int  i;
            for(i=100;i<=999;i++)
            {
                var x = new Program();
                if (x.Prim(i)==1)
                {
                    int o = 0, cp = i;
                    while(cp!=0)
                    {
                        o = o * 10 + cp % 10;
                        cp = cp / 10;
                    }
                    if(x.Prim(o)==1)
                        Console.WriteLine(i);
                }
                        
            }
        }
    }
}
