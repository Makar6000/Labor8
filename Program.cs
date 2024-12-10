using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddItem(new Item("Ремонт сантехника, электрика, мебель", 200));
            menu.AddItem(new Item("Отделочные работы, ремонт стен, потолков", 650));
            menu.AddItem(new Item("Мелкий ремонт", 75));

            Order order = new Order(new List<Item>());
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Каталог услуг ===");
                Console.WriteLine("1. Изучить оказываемые услуги");
                Console.WriteLine("2. Добавить услугу в заказ");
                Console.WriteLine("3. Подтвердить заказ");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите опцию: ");

                string choice = Console.ReadLine();
             
                switch (choice)
                {
                    case "1":
                        menu.DisplayMenu();
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Write("Введите номер услуги для добавления в заказ: ");
                        int itemNumber;
                        if (int.TryParse(Console.ReadLine(), out itemNumber) && itemNumber > 0 && itemNumber <= menu.Items.Count)
                        {
                            order.AddItem(menu.Items[itemNumber - 1]);
                            Console.WriteLine($"'{menu.Items[itemNumber - 1].Name}' добавлен в заказ.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный номер.");
                        }
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        break;

                    case "3":
                        if (order.Items.Count > 0)
                        {
                            Console.WriteLine("Заказ подтвержден!");
                            Console.WriteLine($"Общая сумма: {order.TotalAmount:C}");
                        }
                        else
                        {
                            Console.WriteLine("Ваш заказ пуст.");
                        }
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}