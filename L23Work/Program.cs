using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L23Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n=Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);

            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int res = 1;
            for (int i = 1; i < n; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Результат: {res}");
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
