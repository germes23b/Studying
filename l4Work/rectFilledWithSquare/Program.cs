using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectFilledWithSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число a:");
            float a = Convert.ToSingle(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("Число a должно быть положительным, введите число a:");
                a = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("Введите положительное число b:");
            float b = Convert.ToSingle(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("Число b должно быть положительным, введите число b:");
                b = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("Введите положительное число c:");
            float c = Convert.ToSingle(Console.ReadLine());
            while (c <= 0)
            {
                Console.WriteLine("Число c должно быть положительным, введите число c:");
                c = Convert.ToSingle(Console.ReadLine());
            }
            if (a < c || b < c) Console.WriteLine("При введённых числах невозможно разместить квадрат со стороной {0} в прямоугольнике размером {1} на {2}", c, a, b);
            else
            {
                int n = 0;

                while (a >= c)
                {
                    float d = b;        //  Вводим доп переменную для внутреннего цикла, чтобы не потерять b на итерациях
                    while (d >= c)
                    {
                        n++;
                        d -= c;
                    }
                    a -= c;

                }
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
