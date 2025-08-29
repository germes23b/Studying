using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k=Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            
            Pryamaya pryamaya = new Pryamaya(k,b);
            Console.WriteLine(pryamaya.Root());
            Console.ReadKey();
        }
    }
}
