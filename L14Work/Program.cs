using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как зовут котика?");
            string catName=Console.ReadLine();
            Console.WriteLine("Как зовут собачку?");
            string dogName = Console.ReadLine();
            Cat cat = new Cat(catName);
            Dog dog = new Dog(dogName);
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
