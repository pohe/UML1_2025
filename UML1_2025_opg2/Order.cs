using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1_2025_opg2
{
    public class Order
    {

        private const int _deliveryCost = 40;
        private static int _oNumber = 0;

        public int OrderNumber { get; private set; }

        public DateTime OrderDateTime { get; private set; }

        public bool ToBedelivered { get; set; }

        private Customer _customer;
        private List<Pizza> _pizzas;

        public Order(Customer customer,  bool toBeDelivered)
        {
            _oNumber++;
            OrderNumber = _oNumber;
            OrderDateTime = DateTime.Now;
            _customer = customer;
            ToBedelivered = toBeDelivered;
            _pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            _pizzas.Add(pizza); 
        }

        public double CalculateTotalPrice()
        {
            int pizzaSum = 0; 
            foreach(Pizza p in _pizzas)
            {
                pizzaSum = pizzaSum + p.Price;
            }
            if (ToBedelivered)
                return pizzaSum * 1.25 + _deliveryCost;
            else
                return pizzaSum * 1.25;
        }

        public override string ToString()
        {
            string pizzasInOrder = "";
            foreach(Pizza p in _pizzas)
            {
                pizzasInOrder = pizzasInOrder + p.ToString() + "\n\t"; 
            }
            return $"\tOrdrenummer : {OrderNumber} er bestilt {OrderDateTime.ToString()} \n\taf {_customer} \n\tog der er bestilt {pizzasInOrder} \n\tden totale pris inklusiv moms er {CalculateTotalPrice()} kr\n\tOrdren {(ToBedelivered ? "leveres" : "afhentes i butikken")}";
        }

    }
}
