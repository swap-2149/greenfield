using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IOrderProcessing
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);
        DateTime GetDate(int id);
    }
}
