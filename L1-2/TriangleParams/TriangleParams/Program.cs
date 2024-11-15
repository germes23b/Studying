using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Координаты первой вершины
            Console.WriteLine("Введите координаты первой вершины треугольникаа:");
            Console.WriteLine("Абсцисса первой вершины -  x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ордината первой вершины -  y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            //  Координаты второй вершины
            Console.WriteLine("Теперь - координаты второй вершины");
            Console.WriteLine("Абсцисса второй вершины -  x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ордината второй вершины -  y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //  Координаты третьей вершины
            Console.WriteLine("Теперь - координаты третьей вершины");
            Console.WriteLine("Абсцисса третьей вершины -  x2: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ордината третьей вершины -  y2: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            //  Для удобства вычислим длину сторон треугольника для дальнейшего использования
            double sideAB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double sideBC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double sideAC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            
            //  Вычисляем полупериметр - для последующих вычислений
            double p = (sideAB + sideAC + sideBC) / 2;

            //  Находим площадь треугольника по формуле Герона
            double S = Math.Sqrt(p * (p - sideAB) * (p - sideBC) * (p - sideAC));

            //  Выводим полученные результаты.
            Console.Write("Периметр нашего треугольника:");
            // Для периметра не будем вводить отдельной формулы, просто удвоим полупериметр
            Console.WriteLine(p*2);
            Console.Write("Площадь нашего треугольника :");
            Console.WriteLine(S);
            
            //  Добавим для удобства запрос на выход.
            Console.WriteLine("Нажмите любую клавишу для завершения работы программы (и закрытию окна)");
            Console.ReadKey();
        }
    }
}
