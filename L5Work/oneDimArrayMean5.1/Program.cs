using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimArrayMean5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Single[] array = Single[7];
            single s= 0;

            Console.WriteLine("Введите 7 чисел для заполнения массива:");
            for (int i = 0; i < 7; i++) 
            {
                array[i] = Convert.ToSingle(Console.ReadLine());
                s += array[i];     
            }
            Console.WriteLine(s / 7);
    }
}
