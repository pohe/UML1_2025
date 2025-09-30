using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1_2025_opg5
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public Pizza(int number, string name, string description, int price)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Description} {Price} kr.";
        }

    }
}
