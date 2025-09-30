using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L19Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
            new Computer(){Model="Asus ROG Zephyrus G16 GU605", ProcType="Intel", ClockSpeed=2.9 , RamValue=64, HddValue=2000, VideoValue=24, Quantity=3, Price=19000 },
            new Computer(){Model="MSI Titan GT77 HX V13", ProcType="Intel", ClockSpeed=2.9 , RamValue=32, HddValue=3000, VideoValue=16, Quantity=0, Price=17500 },
            new Computer(){Model="Ноулайфер-2025", ProcType="Эльбрус", ClockSpeed=1.9 , RamValue=16, HddValue=1000, VideoValue=16, Quantity=23, Price=38750 },
            new Computer(){Model="Ламерок-2023", ProcType="Эльбрус", ClockSpeed=1.1 , RamValue=8, HddValue=5000, VideoValue=8, Quantity=30, Price=2999 },
            new Computer(){Model="Thunderobot Zero G4 Radiant", ProcType="Intel", ClockSpeed=2.7 , RamValue=64, HddValue=2000, VideoValue=16, Quantity=8, Price=15000 },
            new Computer(){Model="Acer Predator Helios Neo 16", ProcType="Intel", ClockSpeed=2.1 , RamValue=16, HddValue=1000, VideoValue=8, Quantity=45, Price=6999 },
            new Computer(){Model="Dell Alienware M16 R2", ProcType="Ryzen", ClockSpeed=4.8 , RamValue=16, HddValue=1000, VideoValue=8, Quantity=15, Price=13275 },
            new Computer(){Model="Asus ROG Strix SCAR 18", ProcType="Ryzen", ClockSpeed=2.7 , RamValue=64, HddValue=4000, VideoValue=24, Quantity=1, Price=14900 },
            new Computer(){Model="Lenovo Legion Pro 5i", ProcType="Intel", ClockSpeed=2.2 , RamValue=32, HddValue=1000, VideoValue=8, Quantity=99, Price=23000 },
            new Computer(){Model="Maibenben X16A", ProcType="Ryzen", ClockSpeed=3.1 , RamValue=16, HddValue=500, VideoValue=8, Quantity=13, Price=5600 },
            };

            //  1.  Выводим компьютеры с запрошенным у пользователя типом процессора.

            List<string> procTypeList = computers.Select(x => x.ProcType).ToList();     //  Попробуем вывести в запросе все виды типов процессоров, для удобства пользователя. Выберем в список строк типы.
            procTypeList = procTypeList.Distinct().ToList();        //  Оставим только уникальные.
            string typesStr = "";       //          Заведём переменную для вывода
            foreach (var type in procTypeList)      //  Заполним её
            {
                if (typesStr == "") typesStr = $"{type}";
                else typesStr += $", {type}";
            }
            Console.WriteLine($"Введите тип процессора({typesStr}):");
            string procType = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.ProcType == procType).ToList();
            Print(computers1);
            Console.ReadKey();

            //  2.  Выводим все компьютеры с не меньшим, чем запросил пользователь, объёмом ОЗУ. Тоже выведем в скобках пределы.

            Console.WriteLine($"Введите требуемый минимальный объём ОЗУ({computers.Min(x => x.RamValue)}-{computers.Max(x => x.RamValue)}ГБ):");
            int minRamValue = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RamValue >= minRamValue).ToList();
            Print(computers2);
            Console.ReadKey();
            //  3.  Выводим весь список, сортируем по увеличению стоимости.
            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Console.WriteLine("От бюджетного к дорогому:");
            Print(computers3);
            Console.ReadKey();

            //  4.  Выводим весь список, сгруппированный по типу процессора.
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.ProcType);
            foreach (IGrouping<string, Computer> grp in computers4)
            {
                Console.WriteLine(grp.Key);
                foreach (Computer comp in grp)
                {
                    Console.WriteLine($"{comp.Model}: Проц {comp.ProcType} {comp.ClockSpeed} ГГц. ОЗУ:{comp.RamValue} Гб. HDD:{comp.HddValue} Гб. Видео:{comp.VideoValue} Гб. Цена:{comp.Price} у.е. Кол-во:{comp.Quantity} шт.");
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            //  5.  Находим самый дорогой и самый бюджетный компьютер.
            Computer maxPriceComp = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine($"{maxPriceComp.Model}: Проц {maxPriceComp.ProcType} {maxPriceComp.ClockSpeed} ГГц. ОЗУ:{maxPriceComp.RamValue} Гб. HDD:{maxPriceComp.HddValue} Гб. Видео:{maxPriceComp.VideoValue} Гб. Цена:{maxPriceComp.Price} у.е. Кол-во:{maxPriceComp.Quantity} шт.");
            Computer minPriceComp = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine("Самый дешевый компьютер:");
            Console.WriteLine($"{minPriceComp.Model}: Проц {minPriceComp.ProcType} {minPriceComp.ClockSpeed} ГГц. ОЗУ:{minPriceComp.RamValue} Гб. HDD:{minPriceComp.HddValue} Гб. Видео:{minPriceComp.VideoValue} Гб. Цена:{minPriceComp.Price} у.е. Кол-во:{minPriceComp.Quantity} шт.");
            Console.WriteLine();
            Console.ReadKey();
            //  6.  Есть ли хотя бы один компьютер в количестве не менее 30?
            if (computers.Any(x => x.Quantity >= 30))
                Console.WriteLine("Есть позиции не менее 30 штук в наличии!");
            else Console.WriteLine("В наличии нет ноутбуков в количестве не менее 30.");
            Console.ReadKey();

        }
        //  Блок вывода для удобства сделаем, это удобно.
        static void Print(List<Computer> computers)
        {
            foreach (Computer pc in computers)
            {
                Console.WriteLine($"{pc.Model}: Проц {pc.ProcType} {pc.ClockSpeed} ГГц. ОЗУ:{pc.RamValue} Гб. HDD:{pc.HddValue} Гб. Видео:{pc.VideoValue} Гб. Цена:{pc.Price} у.е. Кол-во:{pc.Quantity} шт.");
            }
            Console.WriteLine();
        }
    }
}
