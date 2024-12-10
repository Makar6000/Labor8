using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public class Item
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetDetails()
        {
            return $"{Name}: {Price:C}";
        }
    }
}
//рпыфавдлпглыфогв