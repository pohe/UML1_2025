using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2025_opg4
{
    public class OrderLine
    {
        private Pizza _pizza;

        public int Number { get; set; }

        private List<Topping> _toppings;

        public string Comment
        {
            get;
            set;
        }
        public double Total
        {
            get
            {
                double totalToppingPrice = 0;
                foreach (Topping t in _toppings)
                {
                    totalToppingPrice = totalToppingPrice + t.Price;
                }
                return _pizza.Price + totalToppingPrice;
            }
        }

        public void AddComment(string comment)
        {
            Comment = comment;
        }

        public OrderLine(Pizza pizza, int number, string comment, List<Topping> toppings)
        {
            _pizza = pizza;
            Number = number;
            Comment = comment;
            if (toppings != null)
                _toppings = toppings;
            else
                _toppings = new List<Topping>();

        }

        public override string ToString()
        {
            string toppingsString = "";
            foreach (Topping t in _toppings)
            {
                toppingsString = toppingsString + t + "\n\t";
            }
            return $"{Number} stk {_pizza} {(Comment != null || Comment != "" ? "kommentar" : "")} {Comment} {(toppingsString != "" ? "\n\tekstra topping" : "")}{toppingsString} totalprice {Total} kr";
        }

    }
}
