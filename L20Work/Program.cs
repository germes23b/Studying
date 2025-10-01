using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20Work
{
    internal class Program
    {
        delegate double MyDelegRes(double x);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegRes ourDeleg = CircleLenght;
            double res = ourDeleg(r);
            Console.WriteLine(res);

            ourDeleg = CircleSquare;
            res = ourDeleg(r);
            Console.WriteLine(res);

            ourDeleg = SphereValue;
            Console.WriteLine(ourDeleg(r));
            Console.ReadKey();

        }
        static double CircleLenght(double r) => (2 * Math.PI * r);
        static double CircleSquare(double r) => (Math.PI * Math.Pow(r, 2));
        static double SphereValue(double r) => ((double)4 / 3 * Math.PI * Math.Pow(r, 3));
    }
}
