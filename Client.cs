using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Client
    {
        public string Name { get; private set; } // Имя клиента
        public Order Order { get; private set; } // Заказ клиента

        public Client(string name)
        {
            Name = name;
        }

        // Метод для создания заказа
        public void MakeOrder(List<Item> items)
        {
            Order = new Order(items);
            Console.WriteLine($"{Name} сделал заказ.");
        }

        // Метод для оплаты счета
        public void PayBill(Bill bill)
        {
            if (bill.IsPaid)
            {
                Console.WriteLine("Счет уже оплачен.");
            }
            else
            {
                bill.Pay();
                Console.WriteLine($"{Name} оплатил счет.");
            }
        }
    }
}
