using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Кошечка говорит \"мяу\", собачка говорит \"гав\", калькулятор говорит \"Приветствую. Я Калькулятор, смотритель Сети Убежищ.\"");
                Console.Write("Введите первое число:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число:");
                double y = Convert.ToDouble(Console.ReadLine());

            }
            catch (exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.ReadKey();
        }
    }
}
