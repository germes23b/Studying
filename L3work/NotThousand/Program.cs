using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotThousand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне 100-999:");
            int a = Convert.ToInt32(Console.ReadLine());
            string strHung = "";
            string strDec = "";
            string strEd = "";
            if (a  > 99 && a  < 1000)
            {
                switch (a / 100)
                {
                    case 1:
                        strHung = "сто";
                        break;
                    case 2:
                        strHung = "двести";
                        break;
                    case 3:
                        strHung = "триста";
                        break;
                    case 4:
                        strHung = "четыреста";
                        break;
                    case 5:
                        strHung = "пятьсот";
                        break;
                    case 6:
                        strHung = "шестьсот";
                        break;
                    case 7:
                        strHung = "семьсот";
                        break;
                    case 8:
                        strHung = "восемьсот";
                        break;
                    case 9:
                        strHung = "девятьсот";
                        break;
                }
                
                if (a % 100 > 9 && a % 100 < 21)
                    switch ( a% 100)
                    {
                        case 10:
                            
                            Console.WriteLine($"Введено число {strHung} десять");
                            break;
                        case 11:
                            Console.WriteLine($"Введено число {strHung} одиннадцать");
                            break;
                        case 12:
                            Console.WriteLine($"Введено число {strHung} двенадцать");
                            break;
                        case 13:
                            Console.WriteLine($"Введено число {strHung} тринадцать");
                            break;
                        case 14:
                            Console.WriteLine($"Введено число {strHung} четырнадцать");
                            break;
                        case 15:
                            Console.WriteLine($"Введено число {strHung} пятнадцать");
                            break;
                        case 16:
                            Console.WriteLine($"Введено число {strHung} шестнадцать");
                            break;
                        case 17:
                            Console.WriteLine($"Введено число {strHung} семнадцать");
                            break;
                        case 18:
                            Console.WriteLine($"Введено число {strHung} восемнадцать");
                            break;
                        case 19:
                            Console.WriteLine($"Введено число {strHung} девятнадцать");
                            break;
                        case 20:
                            Console.WriteLine($"Введено число {strHung} двадцать");
                            break;
                    }
                
                else 
                {
                    switch ((a % 100) / 10)
                    {
                        case 0:
                            break;
                        case 2:
                            strDec = "двадцать";
                            break;
                        case 3:
                            strDec = "тридцать";
                            break;
                        case 4:
                            strDec = "сорок";
                            break;
                        case 5:
                            strDec = "пятьдесят";
                            break;
                        case 6:
                            strDec = "шестьдесят";
                            break;
                        case 7:
                            strDec = "семьдесят";
                            break;
                        case 8:
                            strDec = "восемьдесят";
                            break;
                        case 9:
                            strDec = "девяносто";
                            break;
                    }
                    switch ((a % 100) % 10)
                    {
                        case 0:
                            strEd = "";
                            break;
                        case 1:
                            strEd = "один";
                            break;
                        case 2:
                            strEd = "два";
                            break;
                        case 3:
                            strEd = "три";
                            break;
                        case 4:
                            strEd = "четыре";
                            break;
                        case 5:
                            strEd = "пять";
                            break;
                        case 6:
                            strEd = "шесть";
                            break;
                        case 7:
                            strEd = "семь";
                            break;
                        case 8:
                            strEd = "восемь";
                            break;
                        case 9:
                            strEd = "девять";
                            break;

                    }
                    Console.WriteLine($"Введено число {strHung} {strDec} {strEd}");
                }
            }

            else Console.WriteLine("Введено число за границами диапазона!");
            Console.ReadKey(); 
        }
    }
}
