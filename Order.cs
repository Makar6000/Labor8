using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Order
    {
        public List<Item> Items { get; private set; } // Список заказанных элементов
        public double TotalAmount { get; private set; } // Общая сумма заказа
        public string Status { get; set; } // Добавлен метод set для возможности изменения статуса

        public Order(List<Item> items)
        {
            Items = items;
            CalculateTotal();
            Status = "Pending"; // Начальный статус
        }

        // Метод для добавления элемента в заказ
        public void AddItem(Item item)
        {
            Items.Add(item);
            CalculateTotal();
        }

        // Метод для подтверждения заказа
        public void ConfirmOrder()
        {
            Status = "Confirmed"; // Теперь можно изменять статус
            Console.WriteLine("Заказ подтвержден.");
        }

        // Метод для расчета общей суммы заказа
        private void CalculateTotal()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.Price;
            }
        }
    }
}
