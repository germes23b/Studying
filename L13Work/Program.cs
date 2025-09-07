using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес здания:");
            string adr=Console.ReadLine();
            Console.WriteLine("Введите длину здания:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину здания:");
            int y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту здания:");
            int z= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество этажей:");
            int f = Convert.ToInt32(Console.ReadLine());
            MultiBuilding multiBuilding = new MultiBuilding(adr,x,y,z,f);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
