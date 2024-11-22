using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCubeParams7._2
{
    internal class Program
    {
        static void GetCubeVolSurf(double a, out double v, out double s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetCubeVolSurf(a, out v, out s);
            Console.WriteLine("Объем куба - {0:.00}, площадь его поверхности - {1:.00}", v, s);
            Console.ReadKey();
        }
    }
}
