using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimArrayMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] array = new float[7];
            float s = 0;
            Console.WriteLine("Введите последовательно 7 чисел массива:");
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToSingle(Console.ReadLine());
                s += array[i];
            }

            Console.WriteLine("Среднее арифметическое введённого массива: {0}", ((float)s / 7));
            Console.ReadKey();
        }
    }
}
