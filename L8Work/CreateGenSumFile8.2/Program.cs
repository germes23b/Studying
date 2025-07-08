using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenSumFile8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "NumForSum3.txt";
            Random rnd = new Random();
            double  sum= new double();
            if (!File.Exists(path)) 
            { 
                var ourFile=File.Create(path); 
                ourFile.Close();
            }

            using (StreamWriter sw = new StreamWriter(path,false))
            {
                for (int i = 0; i < 10; i++)
                { 
                sw.WriteLine(rnd.Next(-100, 100));   
                }
                sw.Close();
            }
                        
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                  sum+=Convert.ToInt32(sr.ReadLine());
                }
            }

            Console.WriteLine("Создан (или перезаписан) файл: {0}",path);
            Console.WriteLine("Сумма сгенерированных и записанных в него 10 случайных чисел : {0}",sum);
            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
