using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace L16Work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = string.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            Products[] products = JsonSerializer.Deserialize<Products[]>(jsonString);

            Products maxPrice = products[0];
            foreach (Products p in products)
            {
                if (p.Price > maxPrice.Price)
                {
                    maxPrice = p;
                }
            }
            Console.WriteLine($"Самый дорогой товар - {maxPrice.Name}");
            Console.ReadKey();
        }
    }
}
