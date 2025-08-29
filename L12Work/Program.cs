using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты центра круга:");
            double x0=Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус круга:");
            double r=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки:");
            double x=Convert.ToDouble(Console.ReadLine());
            double y=Convert.ToDouble(Console.ReadLine());

            double cirLength = Round.GetCircleLength(r);
            double cirSquare = Round.GetCircleSquare(r);
            bool inTheCircle = Round.IsPointInCircle(x, y, x0, y0, r);
            Console.WriteLine($"Введённый круг имеет длину окружности {cirLength} и площадь {cirSquare}.");
            if(inTheCircle)
                Console.WriteLine("Указанная точка лежит принадлежит кругу.");
            else
                Console.WriteLine("Указанная точка лежит вне круга.");
            Console.ReadKey();
        }
    }
}
