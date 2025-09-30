using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2025_opg3
{
    public class Order
    {

        private const int _deliveryCost = 40;
        private static int _oNumber = 0;

        public int OrderNumber { get; private set; }

        public DateTime OrderDateTime { get; private set; }

        public bool ToBedelivered { get; set; }

        private Customer _customer;
        private List<OrderLine> _orderLines;

        public Order(Customer customer, bool toBeDelivered)
        {
            _oNumber++;
            OrderNumber = _oNumber;
            OrderDateTime = DateTime.Now;
            _customer = customer;
            ToBedelivered = toBeDelivered;
            _orderLines = new List<OrderLine>();
        }

        public void AddPizza(Pizza pizza, int number, string comment, List<Topping> toppings)
        {
            OrderLine ol = new OrderLine(pizza, number, comment, toppings); 
            _orderLines.Add(ol);
        }

        public double CalculateTotalPrice()
        {
            double orderLineSum = 0;
            foreach (OrderLine ol in _orderLines)
            {
                orderLineSum = orderLineSum + ol.Total;
            }
            if (ToBedelivered)
                return orderLineSum * 1.25 + _deliveryCost;
            else
                return orderLineSum * 1.25;
        }

        public override string ToString()
        {
            string pizzasInOrder = "";
            foreach (OrderLine p in _orderLines)
            {
                pizzasInOrder = pizzasInOrder + p.ToString() + "\n\t";
            }
            return $"\tOrdrenummer : {OrderNumber} er bestilt {OrderDateTime.ToString()} \n\taf {_customer} \n\tog der er bestilt {pizzasInOrder} \n\tden totale pris inklusiv moms er {CalculateTotalPrice()} kr\n\tOrdren {(ToBedelivered ? "leveres" : "afhentes i butikken")}";
        }

    }
}
