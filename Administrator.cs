using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Administrator
    {
        public string Name { get; private set; } // Имя администратора

        public Administrator(string name)
        {
            Name = name;
        }

        // Метод для подтверждения заказа
        public void ConfirmOrder(Order order)
        {
            order.ConfirmOrder();
        }

        // Метод для отправки заказа админу
        public void SendToKitchen(Order order)
        {
            Kitchen.PrepareOrder(order);
            Console.WriteLine("Заказ отправлен администратору.");
        }

        // Метод для создания счета
        public Bill CreateBill(Order order)
        {
            return new Bill(order.TotalAmount);
        }

        // Метод для добавления элемента в каталог
        public void AddItemToMenu(Menu menu, Item item)
        {
            menu.AddItem(item);
            Console.WriteLine($"Пункт каталога '{item.Name}' добавлен.");
        }
    }

}

