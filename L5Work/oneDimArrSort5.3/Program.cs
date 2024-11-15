using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimArrSort5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random rand = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-50, 50);
                Console.Write("{0,3}", array[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Сортируем сгенерированный массив");
            Console.ReadKey();
            for (int i = 0; i < n; i++)     //  Выглядит удобнее, чем делать два цикла на первую и вторую половину.
            {
                if (i < n / 2)      //  т.к. n - чётное, то просто делим цикл пополам и прогоняем по разным знакам.
                {
                    for (int j = i + 1; j < n / 2; j++)     //  Первые пять - по возрастанию.
                    {
                        if (array[i] > array[j])
                        {
                            int m = array[i];
                            array[i] = array[j];
                            array[j] = m;
                        }
                    }
                }
                else
                {
                    for (int j = i + 1; j < n; j++)     //  Вторые 5 - по убиыванию.
                    {
                        if (array[i] < array[j])
                        {
                            int m = array[i];
                            array[i] = array[j];
                            array[j] = m;
                        }
                    }
                }
                Console.Write("{0,3}", array[i]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
