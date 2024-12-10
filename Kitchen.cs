using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public static class Kitchen
    {
        // Метод для подготовки заказа
        public static void PrepareOrder(Order order)
        {
            order.Status = "In Kitchen";
            Console.WriteLine("Приготовление заказа...");
        }

        // Метод для завершения заказа
        public static void CompleteOrder(Order order)
        {
            order.Status = "Completed";
            Console.WriteLine("Заказ выполнен.");
        }
    }
}
