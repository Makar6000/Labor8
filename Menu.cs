using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public class Menu
    {
        private List<Item> items;

        public Menu()
        {
            items = new List<Item>();
        }

        public List<Item> Items
        {
            get { return items; }
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Каталог:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].GetDetails()}");
            }
        }
    }
}
