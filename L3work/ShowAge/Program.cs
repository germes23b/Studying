using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст в диапазоне 20-69 лет:");
            int a = Convert.ToInt32(Console.ReadLine());
            int dec = a / 10;
            int ed= a % 10;
            string strDec="";
            string strEd="";

            if (dec <= 6 && dec >= 2)
            {           
            
            switch (dec)
            {
                case 2:
                    strDec = "двадцать";
                    break;
                case 3:
                    strDec = "тридцать";
                    break ;
                case 4:
                    strDec = "сорок";
                    break ; 
                case 5:
                    strDec = "пятьдесят";
                    break ;
                case 6:
                    strDec = "шестьдесят";
                    break ;
                       }
           
            
                switch (ed)
                {
                    case 0:
                        strEd = "лет";
                        break;
                    case 1:
                        strEd = "один год";
                        break;
                    case 2:
                        strEd = "два года";
                        break;
                    case 3:
                        strEd = "три года";
                        break;
                    case 4:
                        strEd = "четыре года";
                        break;
                    case 5:
                        strEd = "пять лет";
                        break;
                    case 6:
                        strEd = "шесть лет";
                        break;
                    case 7:
                        strEd = "семь лет";
                        break;
                    case 8:
                        strEd = "восемь лет";
                        break;
                    case 9:
                        strEd = "девять лет";
                        break;
                }

                Console.WriteLine($"Введён возраст {strDec} {strEd}");
            }
            else 
                Console.WriteLine("Введённый возраст не отвечает условиям задачи!");
            Console.ReadKey();
        }
    }
}
