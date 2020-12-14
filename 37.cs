using System;

namespace _37
{
    class Program
    {
        public float viteza(float v)
        {
            float trans;
            trans = (float)(v / 3.6);
            return trans;
        }
        static void Main(string[] args)
        {
            float v;
            Console.WriteLine("Viteza este :");
            v = int.Parse(Console.ReadLine());
            var t = new Program();
            Console.WriteLine(t.viteza(v));
        }
    }
}
