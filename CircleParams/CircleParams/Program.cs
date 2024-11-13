using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности");
            double L=Convert.ToDouble(Console.ReadLine());
            double R=(double)L/Math.PI/2;
            Console.WriteLine(R);
            Console.ReadKey();
        }
    }
}
