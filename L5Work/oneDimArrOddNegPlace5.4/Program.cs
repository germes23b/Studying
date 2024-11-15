using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimArrOddNegPlace5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            Random rand = new Random();
            int[] array = new int[n];
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-50, 50);
                Console.Write("{0,3}", array[i]);
                if ((i + 1) % 2 == 0)
                {
                    if (array[i] % 2 == 1) s++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество нечётных положительных элементов массива на чётных местах - {0}.", s);
            Console.ReadKey();
        }
    }
}
