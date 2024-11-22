using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace compareTriangle7._1
{
    internal class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (double)(a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(a1, b1, c1);

            Console.WriteLine("Введите длины сторон второго треугольника: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2=GetSquare(a2, b2, c2);

            if(s1>s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if(s2>s1) Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Треугольники имеют равную площадь");
            Console.ReadKey();
        }
    }
}
