using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L22Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);
            
            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(ArraySum);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(ArrayMax);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Action<Task<int[]>> action = new Action<Task<int[]>>(PrintArray);
            Task task4 = task1.ContinueWith(action);

            task1.Start();
            Console.ReadKey();
        }

        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 50);
            }
            return array;
        }
        static void PrintArray(Task<int[]> task)        
        {   
            int[] array = task.Result;
            Console.Write("Сгенерировался массив: ");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static int ArraySum(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;
            foreach (int item in array)
                sum += item;
            Console.WriteLine($"Сумма чисел массива: {sum}");
            return sum;
        }

        static int ArrayMax(Task<int[]> task)      
        { 
            int[] array = task.Result;
            int mx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                    mx = array[i];
            }
            Console.WriteLine($"Максимальное число из массива: {mx}");
            return mx;
        }
    }
}
