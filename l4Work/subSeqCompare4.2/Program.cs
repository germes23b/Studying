using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSeqCompare4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            int pos = 0;
            int neg = 0;
            do
            {
                Console.WriteLine("Введите число из последовательности чисел. 0 - окончание ввода:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0) pos++;
                if (n < 0) neg++;
                            }
            while (n != 0);
            //  Технически, когда вводим сразу 0 - в последовательности одинаковое количество положительных и отрицательных чисел, так что отдельную проверку не делаем.
            if (pos - neg > 0)
                Console.WriteLine("Во введённой Вами последовательности больше положительных чисел");
            else if (pos - neg < 0)
                Console.WriteLine("Во введённой Вами последовательности больше отрицательных чисел");
            else Console.WriteLine("Во введённой Вами последовательности одинаковое количество положительных и отрицательных чисел");
            Console.ReadKey();
        }
        }
}
