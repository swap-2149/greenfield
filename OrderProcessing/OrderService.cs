using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService : IOrderProcessing
    {
        List<Order> _ordersList;
        public OrderService()
        {
            _ordersList = new List<Order>();
        }
        public bool Delete(int id)
        {
            Order order = GetOrderById(id);
            return _ordersList.Remove(order);
        }

        public List<Order> GetAllOrders()
        {
            return _ordersList;
        }

        public Order GetOrderById(int id)
        {
            foreach (Order order in _ordersList)
            {
                if (order.orderId == id) return order;
            }
            return null;
        }

        public bool Insert(Order order)
        {
            _ordersList.Add(order);
            return true;
        }

        public bool Update(Order order)
        {
            Order temp = this.GetOrderById(order.orderId);
            _ordersList.Remove(temp);
            _ordersList.Add(order);
            return true;
        }
        public DateTime GetDate(int id)
        {
            Order order = this.GetOrderById(id);
            return order.orderDate;
        }
    }
}
