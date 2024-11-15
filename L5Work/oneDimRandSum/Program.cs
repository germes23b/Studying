using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimRandSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[15];
            int max = 0;    //  Всё просто - максимум делаем нижней границей. Любое случайное, кроме нуля, будет больше.
            int min = 50;   //  Тут наоборот - минимум делаем верхней границей. Любое случайное, кроме 50, будет меньше.
            for (int i = 0; i < 15; i++)
            {
                array[i] = rand.Next(0, 50);
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Сгенерирован массив из 15 случайных чисел в диапазоне от 0 до 50. Максимальный - {0}, минимальный -{1}. Сумма максимального и минимального элементов - " + (max + min).ToString(), min, max);
            Console.ReadKey();
        }
    }
}