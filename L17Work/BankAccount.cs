using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17Work
{
    class BankAccount<T>
    {
        private T AccNumber { get; set; }
        private double Balance { get; set; }
        private string Fio { get; set; }

        public void GetInfo()
        {   
            Console.WriteLine($"Номер счёта: {AccNumber} Баланс: {Balance} ФИО: {Fio}");
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите номер счёта:");
            AccNumber=(T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите сумму баланса:");
            Balance=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО:");
            Fio= Console.ReadLine();
        }
    }
}
