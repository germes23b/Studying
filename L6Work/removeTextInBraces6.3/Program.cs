using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeTextInBraces6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку S:");
            string s = Console.ReadLine();        //  Проверку на правильность (количество и положение скобок) делать не будем, слишком громоздко. Пока.
            string strAfterBrace = "";
            while (s.Contains("{") && s.Contains("}"))      //  Пока все не удалим.
            {
                strAfterBrace = s.Substring(s.LastIndexOf("{"));        //  Вся строка после последней открывающей скобки. Ищем в ней первую открывающую.

                s = s.Remove(s.LastIndexOf("{"), strAfterBrace.IndexOf("}") + 1);      //  Удаляем из основной строки подстроку между последней открывающей и первой после неё закрывающей.
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
