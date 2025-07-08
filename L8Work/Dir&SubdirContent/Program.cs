using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dir_SubdirContent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Work";
            string[] listDir = Directory.GetDirectories(path);
            foreach (string dir in listDir)
            {
                Console.WriteLine(dir);
            }

            string[] listFiles = Directory.GetFiles(path,"*", SearchOption.AllDirectories);
            foreach (string file in listFiles)
            { 
            Console.WriteLine(file);
            }
     
            Console.ReadKey();
        }
    }
}
