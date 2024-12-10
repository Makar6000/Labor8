using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public class Bill
    {
        public double Amount { get; private set; } // Сумма счета
        public bool IsPaid { get; private set; } // Статус оплаты

        public Bill(double amount)
        {
            Amount = amount;
            IsPaid = false;
        }

        // Метод для генерации счета
        public void GenerateBill()
        {
            Console.WriteLine($"Счет на сумму: {Amount:C}");
        }

        // Метод для оплаты счета
        public void Pay()
        {
            IsPaid = true;
            Console.WriteLine("Счет оплачен.");
        }
    }
}

