using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalindromeNoSpaceAndCase6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string str=Console.ReadLine();
            string strNorm = str.Replace(" ", "").ToLower();
            string strReverse = "";
          
            foreach (char c in strNorm)     //  Пишем введённую строку справа налево
            {
                strReverse = c + strReverse;
            }

            //if (strReverse.CompareTo(strNorm)==0) Console.WriteLine("Введённое предложение \"{0}\" является палиндромом.",str); упоминался в уроке, но Equals логичнее.
            if (strReverse.Equals(strNorm)) Console.WriteLine("Введённое предложение \"{0}\" является палиндромом.", str); 
            else Console.WriteLine("Введённое предложение \"{0}\" - не палиндром.", str);
            Console.ReadKey();
        }
    }
}
