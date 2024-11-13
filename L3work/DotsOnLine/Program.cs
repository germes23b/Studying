using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotsOnLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки А:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B:");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C:");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            
            double ab = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double ac = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            if (x1 == x2 && y1 == y2 && x2 == x3 && y2 == y3)
                Console.WriteLine("Координаты всех трёх точек совпадают!");
            else
            if (x1 == x2 && y1 == y2)
                Console.WriteLine("Координаты точки В совпадают с координатами точки A!");
            else
                if (x1 == x3 && y1 == y3)
                Console.WriteLine("Координаты точки C совпадают с координатами точки A!");
            else
            if (x2 == x3 && y2 == y3)
                Console.WriteLine("Координаты точек В и С совпадают!");
            else
            if (ab > ac)
                Console.WriteLine("Точка C с координатами {0},{1} ближе к точке A", x3, y3);
            else
                if (ac > ab)
                Console.WriteLine("Точка B с координатами {0},{1} ближе к точке A", x2, y2);
            else
                Console.WriteLine("Точки В и С равноудалены от точки А");
            Console.ReadKey();
        }
    }
}
