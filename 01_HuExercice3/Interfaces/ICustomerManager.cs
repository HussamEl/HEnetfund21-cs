using _01_HuExercice3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Interfaces
{
    internal interface ICustomerManager : IAuthentication
    {
        Customer CreateCustomer(Customer customer, string password);

        Customer GetCustomer(Guid id);

        IEnumerable<Customer> GetCustomers();
              
        void DeleteCustomer(Guid id);
                    

    }
}
