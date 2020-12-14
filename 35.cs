
using System;
namespace _35
{
    class Program
    {
        double pi = 3.14;
        public double transformare1(double radiani)
        {
            double grade;
            grade = radiani * 180 / pi;
            return grade;
        }
        public double transformare2(double grade)
        {
            double radiani;
            radiani = grade * pi/ 180;
            return radiani;
        }
        static void Main(string[] args)
        {
            double radiani, grade, c;
            Console.WriteLine("Ce transformare doriti sa efectuati? Tastati 1 pentru transformare din radiani in grade,altfel tastati 2");
            c = int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:
                    Console.WriteLine("Introduceti valoarea in radiani a unghiului: ");
                    radiani = int.Parse(Console.ReadLine());
                    var t = new Program();
                    Console.WriteLine(t.transformare1(radiani));
                    break;
                case 2:
                    Console.WriteLine("Introduceti valoarea in grade a unghiului:");
                    grade = int.Parse(Console.ReadLine());
                    var p = new Program();
                    Console.WriteLine(p.transformare2(grade));
                    break;


            }
        }
    }
}
