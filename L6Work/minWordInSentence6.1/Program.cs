using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minWordInSentence6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение с клавиатуры. Не используйте знаки препинания - просто слова, разделённые пробелом:");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string strMax = strArray[0];
            foreach (string s in strArray)
            {
                if (s.Length > strMax.Length)
                    strMax = s;
            }
            Console.WriteLine("Самое длинное слово во введённом предложении - {0}", strMax);
            Console.ReadKey();
        }
    }
}
