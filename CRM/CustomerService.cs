using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : ICustomerService
    {
        List<Customer> _customerList;
        public CustomerService() { 
            _customerList = new List<Customer>();
        }
        public bool Delete(int id)
        {
            foreach(Customer c in _customerList)
            {
                if(c.Id == id)
                {
                    _customerList.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public List<Customer> GetAll()
        {
            _customerList.Add(new Customer { Id = 1, FirstName = "Swap", LastName = "Patil", Contact = "998988985", Email = "swap@gmail.com" });
            return _customerList;
        }

        public Customer GetCustomerById(int id)
        {
            foreach (Customer c in _customerList)
            {
                if (c.Id == id) { return c; }
            }
            return null;
        }

        public bool Insert(Customer customer)
        {
            _customerList.Add(customer); 
            return true;
        }

        public Customer Update(Customer customer)
        {
            foreach(Customer c in _customerList)
            {
                if(c.Id == customer.Id)
                {
                    c.FirstName = customer.FirstName;
                    c.LastName = customer.LastName;
                    c.Email = customer.Email;
                    c.Contact = customer.Contact;
                    return c;
                }
            }
            return null;
        }
    }
}
