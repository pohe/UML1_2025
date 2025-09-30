using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2025_opg4
{
    public class Topping
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Topping(string name, int price)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return $"topping {Name} pris {Price} kr.";
        }
    }
}
