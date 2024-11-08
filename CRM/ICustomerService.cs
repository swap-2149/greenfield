using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetCustomerById(int id);

        bool Insert(Customer customer);

        Customer Update(Customer customer);

        bool Delete(int id);
    }
}
