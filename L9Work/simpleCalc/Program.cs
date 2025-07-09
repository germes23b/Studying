using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0;      //  Взяли decimal вместо привычных double - double обходит исключение деления на 0, а для нас это показательный случай.
            decimal b = 0;
            Console.WriteLine("Кошечка говорит \"мяу\", собачка говорит \"гав\", калькулятор говорит \"Приветствую. Я Калькулятор, смотритель Сети Убежищ.\"");
            while (true)        //  Подсмотрел в интернете, чтобы в случае ошибки возвращаться к началу, так удобнее
            {
                try
                {
                    Console.WriteLine("Начало работы.");        //  Добавим для удобства, чтобы видеть начало цикла работы программы.
                    Console.Write("Введите первое число(a):");      //  Вводим a и b, считывая их с клавиатуры
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите второе число(b):");
                    b = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException)     //  Когда введены неподходящие символы (или не введено ничего)
                {
                    Console.WriteLine("Допустимые для ввода символы - цифры и разделитель целой и дробной части(запятая):");
                    continue;       //  Выходим в начало цикла, чтобы ошибка не закрывала программу, а запускала новый цикл.
                }
                catch (Exception exc)       //  Для остальных исключений просто будем выводить сообщения
                {
                    Console.WriteLine(exc.Message);
                    continue;
                }
                Console.Write("Выберите нужную операцию : \n 1 - сложение \n 2 - вычитание \n 3 - умножение \n 4 - деление \n Выбор:");
                try
                {
                    int oper = Convert.ToInt32(Console.ReadLine());
                    switch (oper)
                    {
                        case 1:
                            Console.WriteLine("Результат сложения чисел(a+b): " + (a + b).ToString());
                            break;
                        case 2:
                            Console.WriteLine("Результат вычитания чисел(a-b): " + (a - b));
                            break;
                        case 3:
                            Console.WriteLine("Результат умножения чисел(a*b): " + (a * b));
                            break;
                        case 4:
                            decimal c = a / b;
                            Console.WriteLine("Результат деления чисел(a/b): " + c);
                            break;
                        default:
                            Console.WriteLine("Операция выбрана неверно!");     //  Здесь можно было ArgumentOutOfRangeException, но выглядит интереснее в таком виде.
                            break;
                    }
                    Console.WriteLine("Для завершения программы нажмите любую клавишу...");
                    Console.ReadKey();
                    break;      //  Это наш выход из "вечного" цикла. Можно ещё добавить горячую клавишу, но это выходит за рамки, поэтому не будем пока.
                }
                catch (FormatException)     //  Когда ввели что-то не то в операции
                {
                    Console.WriteLine("Операция выбрана неверно!");
                    continue;
                }
                catch (DivideByZeroException)       //  Когда b=0. Для этого сделали a b decimal.
                {
                    Console.WriteLine("На ноль делить нельзя. Даже если очень хочется!");
                    continue;
                }
                catch (Exception ex)        //  Для всех остальных исключений просто выводим текст.
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
