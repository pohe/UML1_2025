using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1_2025
{
    public class Order
    {
        private const int _deliveryCost = 40; 
        private static int _oNumber = 0;
        public int OrderNumber { get; private set; }
        public DateTime OrderDateTime { get; private set; }

        public bool ToBedelivered { get; set; }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer;}
        }

        private Pizza _pizza;

        public Order(Customer customer, Pizza pizza, bool toBeDelivered)
        {
            _oNumber++;
            OrderNumber = _oNumber;
            OrderDateTime = DateTime.Now;
            _customer = customer;
            _pizza = pizza;
            ToBedelivered = toBeDelivered;
        }

        public double CalculateTotalPrice()
        {
            if (ToBedelivered)
                return _pizza.Price * 1.25 + _deliveryCost;
            else
                return _pizza.Price * 1.25; 
        }

        public override string ToString()
        {
            return $"\tOrdrenummer : {OrderNumber} er bestilt " +
                $"{OrderDateTime} \n\taf {_customer} " +
                $"\n\tog der er bestilt {_pizza} " +
                $"\n\tden totale pris inklusiv moms er {CalculateTotalPrice()} kr\n\tOrdren {(ToBedelivered?"leveres":"afhentes i butikken") }";
        }

    }
}
