using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FourCorner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины прямоугольника:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины прямоугольника:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины прямоугольника:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4=0;       //  Чтобы не ругался на объявленные переменные без значений.
            int y4=0;

            // Проверяем, можно ли нарисовать прямоугольник со сторонами, параллельными ОХ и ОУ:
            if ((x1 != x2 && x1 != x3 && x2 != x3) || (y1 != y2 && y1 != y3 && y2 != y3))
                Console.WriteLine("По заданным координатам невозможно построить прямоугольник со сторонами, параллельными OX и OY");
            else
            {
                if (x1 == x2)
                {
                    if (y2 == y3)
                    {
                        x4 = Convert.ToInt32(x3);
                        y4 = Convert.ToInt32(y1);
                    }
                    else
                    {
                        x4 = Convert.ToInt32(x3);
                        y4 = Convert.ToInt32(y2);
                    }    
                }
                else
                    if (x2 == x3)
                {
                    if (y1==y2)
                    {
                        x4 = Convert.ToInt32(x1);
                        y4 = Convert.ToInt32(y3);
                    }
                    else
                    {
                        x4 = Convert.ToInt32(x1);
                        y4 = Convert.ToInt32(y2);
                    }
                        }
                else
                    if (x1 == x3)
                {
                    if (y1 == y2)
                    {
                        x4 = Convert.ToInt32(x2);
                        y4 = Convert.ToInt32(y3);
                    }
                    else
                    {
                        x4 = Convert.ToInt32(x2);
                        y4 = Convert.ToInt32(y1);
                    }
                 }
            }
            Console.WriteLine($"Координаты четвертой вершины - {x4},{y4}");
            Console.ReadKey();
        }
    }
}
