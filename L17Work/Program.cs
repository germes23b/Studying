using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAcc1 = new BankAccount<int>();
            BankAccount<string> bankAcc2 = new BankAccount<string>();
            Console.WriteLine("Первый счёт(числовой формат)");
            bankAcc1.SetInfo();
            Console.WriteLine("Второй счёт(текстовый формат)");
            bankAcc2.SetInfo();
            bankAcc1.GetInfo();
            bankAcc2.GetInfo();
            Console.ReadKey();
        }
    }
}
