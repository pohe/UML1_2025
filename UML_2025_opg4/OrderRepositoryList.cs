using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2025_opg4
{
    public class OrderRepositoryList
    {
        private List<Order> _orders;

        public OrderRepositoryList()
        {
            _orders = new List<Order>();
        }

        public int Count { get { return _orders.Count; } }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order? SearchOrder(int orderNumber)
        {
            foreach (Order o in _orders)
            {
                if (o.OrderNumber == orderNumber)
                {
                    return o;
                }
            }
            return null;
        }

        public void DeleteOrder(int orderNumber)
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].OrderNumber == orderNumber)
                {
                    _orders.RemoveAt(i);
                    return;
                }
            }
        }

        public void UpdateOrder(int orderNumber, Order upDatedOrder)
        {
            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].OrderNumber == orderNumber)
                {
                    _orders[i] = upDatedOrder; 
                    return;
                }
            }
        }

        public void PrintAll()
        {
            foreach(Order o in _orders)
            {
                Console.WriteLine(o);
            }
        }
    }
}
