using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace E_commerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerService customerService = new CustomerService();
            customerService.Insert(new Customer { Id = 1, FirstName = "Swap", LastName = "Patil", Contact = "987654567", Email = "swap.patil@gmail.com" });
            customerService.Insert(new Customer { Id = 2, FirstName = "Neil", LastName = "Patil", Contact = "987654345", Email = "neil.patil@gmail.com" });

            Customer ch = customerService.GetCustomerById(2);
            Console.WriteLine(ch.FirstName);
            Console.WriteLine(ch.LastName);

            Console.ReadLine();
        }
    }
}
