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
            Console.WriteLine("Введите координаты первой вершины прямоугольника:");
            Console.WriteLine("Абсцисса первой вершины -  x1: ");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ордината первой вершины -  y1: ");
            double y1 =Convert.ToDouble(Console.ReadLine());
            
            //  Координаты второй вершины
            Console.WriteLine("Теперь - координаты второй вершины");
            Console.WriteLine("Абсцисса второй вершины -  x2: ");
            double x2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ордината второй вершины -  y2: ");
            double y2 =Convert.ToDouble(Console.ReadLine());

            //  Периметр - сумма сторон, длина стороны - это модуль разницы соответствующих координат вершин
            double P = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1)) * 2;

            // Площадь - произведение длин сторон в данном случае. Сторону мы научились находить в предыдущей строке.
            double S=Math.Abs(x2 - x1)*Math.Abs(y2 - y1);

            //  Выводим полученные результаты.
            Console.Write("Периметр введённого прямоугольника:");
            Console.WriteLine(P);
            Console.Write("Площадь введённого прямоугольника :");
            Console.WriteLine(S);

            //  Добавим для удобства запрос на выход.
            Console.WriteLine("Нажмите любую клавишу для завершения работы программы (и закрытию окна)");
            Console.ReadKey();
                }
    }
}
