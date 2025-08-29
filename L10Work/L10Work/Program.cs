using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов угла:");
            int curGradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут угла:");
            int curMinute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд угла:");
            int curSecond = Convert.ToInt32(Console.ReadLine());

            Angle angle= new Angle(curGradus,curMinute, curSecond);

            double angleInRadians=angle.ToRadians();
            Console.WriteLine("Значение угла в радианах: {0}",angleInRadians);
            Console.ReadKey();
        }
    }
}
