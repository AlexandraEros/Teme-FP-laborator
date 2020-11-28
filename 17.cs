using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int bazamica, bazamare, inaltime, arie = 1;
            Console.Write("Introduceti valoarea pentru baza mica a trapezului: ");
            bazamica = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea pentru baza mare a trapezului: ");
            bazamare = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea pentru inaltimea trapezului: ");
            inaltime = int.Parse(Console.ReadLine());
            arie = (bazamica + bazamare) * inaltime / 2;
            Console.WriteLine("Aria trapezului este: {0}", arie);
        }
    }
}
