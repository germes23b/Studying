using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arProg = new ArithProgression();
            Console.WriteLine("Задаём начальный член прогрессии, разность или знаменатель, и выдаём ряд из 10 следующих членов");
            Console.WriteLine("Введите первый член арифметической прогрессии:");        // Введём первый член прогрессии
            arProg.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите разность прогрессии:");       //  Введём разность прогрессии.
            arProg.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Следующие 3 числа прогрессии:");
            Console.Write(arProg.GetNext() + " ");
            Console.Write(arProg.GetNext() + " ");
            Console.Write(arProg.GetNext() + " ");
            Console.WriteLine();
            arProg.Reset();
            Console.WriteLine("Теперь ряд из следующих 10 членов прогрессии:");
            for (int i = 0; i < 10; i++)        //  Получим ряд из 3 чисел, сбросим и получим из 10.
            {
                Console.Write(arProg.GetNext());
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите  любую клавишу для перехода к геометрической прогрессии...");
            Console.ReadKey();
            GeomProgression geomProg = new GeomProgression();
            Console.WriteLine("Введите первый член геометрической прогрессии:");        // Введём первый член прогрессии
            geomProg.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите знаменатель прогрессии:");       //  Введём знаменатель прогрессии.
            geomProg.SetStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Следующие 3 числа прогрессии:");
            Console.Write(geomProg.GetNext() + " ");
            Console.Write(geomProg.GetNext() + " ");
            Console.Write(geomProg.GetNext() + " ");
            Console.WriteLine();
            geomProg.Reset();
            for (int i = 0; i < 10; i++)        //  Получим ряд из 10 чисел.
            {
                Console.Write(geomProg.GetNext());
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения программы...");
            Console.ReadKey();
        }
    }
}
