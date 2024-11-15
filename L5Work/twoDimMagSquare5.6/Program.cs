using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace twoDimMagSquare5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите размерность массива:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Введено некорректное значение, необходимо ввести положительное целое число");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] s = new int[2 * n + 2];     //  Вводим массив суммы для удобства сравнения
            int k = 0;      //  Вводим счётчик для массива суммы
            int[,] array = new int[n, n];       //  Принципиально от типа данных ничего не меняется, сделаем int
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите {0}-е число {1}-ой строки:", j + 1, i + 1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    s[k] += array[i, j];        //  Собираем сумму строки в член массива. Это даст информацию по строкам уже на этапе ввода
                    if (i == j) s[2 * n + 1] += array[i, j];        //  В последний член массива записываем сумму главной диагонали.
                    if (i + j == n - 1) s[2 * n] += array[i, j];        //  В предпоследний член массива записываем сумму побочной диагонали.
                }
                k++;        //  Переключаем на следующий - первые n членов массива s - это суммы  каждой строки
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    s[k] += array[i, j];
                }
                k++;        //  Переключаем на следующий - от n+1 до 2*n - это суммы каждого столбца.
            }
            Console.WriteLine();
            bool magSquare = true;      //  Вводим логический признак магического квадрата.
            foreach (int с in s)
            {
                if (с != s[0])      //  Сравниваем каждый член массива с первым (все суммы должны быть одинаковы). Если не сошлось - меняем признак на ложь и выходим.
                {
                    magSquare = false;
                    break;
                }
            }
            if (magSquare) Console.WriteLine("Введённая матрица является магическим квадратом!");
            else Console.WriteLine("Введённая матрица не является магическим квадратом!");
            Console.ReadKey();

        }
    }
}