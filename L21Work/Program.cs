using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L21Work
{
    internal class Program
    {
        const int x = 7;
        const int y = 9;
        const int z = 100;      //  Для удобства ещё вписал время, чтобы было проще тестить.
        static int[,] ourArray(int x, int y)        //  Сделаем рандомом массив, чтобы руками не вбивать)
        {
            Random rndGen = new Random();
            int[,] ourField = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    ourField[i, j] = rndGen.Next(0, z);
                }
            }
            return ourField;
        }
        static int[,] myArray = ourArray(x, y);

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(NWGardnerer);
            Thread thread = new Thread(threadStart);
            thread.Start();
            SEGardnerer();
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                   Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void NWGardnerer()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {   
                    int delay = myArray[i,j];
                    if (myArray[i, j] >= 0)     //  Если участок свободен - то задерживаемся и растим прекрасный сад. Если нет - просто идём дальше
                    {
                        myArray[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                    else break;     //  Если занят - заканчиваем цикл, правее всё обработано, нужно на следующую строку.
                }
            }
        }

        static void SEGardnerer()
        {
            for (int j = y - 1; j >= 0; j--)       //  Здесь идём снизу и по вертикали, поэтому сперва столбцы, потом строки.
            {
                for (int i = x - 1; i >= 0; i--)
                {
                    int delay = myArray[i, j];
                    if (myArray[i, j] >= 0)     //  Если участок свободен - то задерживаемся и растим прекрасный с
                    {
                        myArray[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                    else break;     //  Если занят - заканчиваем цикл, выше в столбике всё обработано, нужно "вниз" следующего столбца слева.
                }
            }
        }
    }
}
