using _01_HuExercice3.Interfaces;
using _01_HuExercice3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Handlers
{
    internal class CustomerHandler : ICustomerManager
    {
        private List<Customer> customers = new List<Customer>();
        
        public Customer CreateCustomer(Customer customer, string password)
        {
            customers.Add(customer);
            customer.Id = Guid.NewGuid().ToString();
            customer.CreatePassword(password);

            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }



        public Customer GetCustomer(Guid id)
        {
            throw new NotImplementedException();
        }


        public void DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

 
        public void SIgnOut(string id)
        {
            throw new NotImplementedException();
        }

        public void SignUp(string firstName, string lastName, string email, string password)
        {
            throw new NotImplementedException();
        }

        public string SingIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
