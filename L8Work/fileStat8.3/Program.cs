using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileStat8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "testTextFile.txt";
            int qtySymb = 0;
            int qtyString = 0;
            int qtyWords = 0;
            int curSymbol;      //  Заводим переменные для текущего и следующего символа.
            int nextSymbol;
            using (StreamReader sr = new StreamReader(path))
            {
                qtySymb = sr.ReadToEnd().Length;       //  С количеством символов всё довольно просто - просто читаем файл целиком.
                sr.DiscardBufferedData();       //  Сбрасываем буфер
                sr.BaseStream.Position = 0;         //  Перемещаемся в начало. Возможно, можно сделать это изящнее, но я не осознал, как.
                while (!sr.EndOfStream)      //  Проверяем весь поток, ищем возвраты каретки - на них будет переход.
                {
                    sr.ReadLine();      //  Читаем строку (до возврата каретки)
                    qtyString++;        //  Щелкаем счётчиком строк.
                }
                sr.DiscardBufferedData();       //  Сбрасываем буфер
                sr.BaseStream.Position = 0;     //  Перемещаемся в начало.
                while (!sr.EndOfStream)
                {
                    curSymbol = sr.Read();      //  Ловим текущий символ.
                    nextSymbol = sr.Peek();     //  Ловим следующий символ. чтобы Read'ом не упрыгивать дальше, удобнее так.
                    if (curSymbol <= 1103 && curSymbol >= 1040)     //  Если текущий символ - буква кириллицы (брали ютф-8 кодировку)
                    {
                        if (nextSymbol != 45 && (nextSymbol > 1103 || nextSymbol < 1040)) qtyWords++;       //  Если следующий за ним символ - не буква и не тире - то это признак конца слова.
                    }
                }
                Console.WriteLine("Количество строк в файле - {0}.", qtyString);       
                Console.WriteLine("Количество символов в файле - {0}.", qtySymb);
                Console.WriteLine("Количество слов в файле - {0}.", qtyWords);      
            }
            Console.ReadKey();
        }
    }
}
