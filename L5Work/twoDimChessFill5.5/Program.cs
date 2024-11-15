using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimChessFill5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите размерность массива:");
            n = Convert.ToInt32(Console.ReadLine());
            while ((n <= 0))
            {
                Console.WriteLine("Введено некорректное значение, необходимо ввести положительное целое число");
                n = Convert.ToInt32(Console.ReadLine());
            }
            byte[,] array = new byte[n, n];
            Console.WriteLine("Итоговый вид массива (размер {0} на {0}):", n);
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (i + j) % 2 == 0 ? (byte)1 : (byte)0;
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
