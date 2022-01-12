using _01_HuExercice3.Interfaces;
using _01_HuExercice3.Models;
using _01_HuExercice3.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Handlers
{
    
    internal interface IAuthHandler
    {
        void SignUp(SignUpForm formInputs);
        string SignIn(SignInForm formInputs);
        void SignOut(string id);
    }

    internal class AuthHandler : IAuthHandler
    {
        ICustomerManager _customerManager = new CustomerHandler();



        public string SignIn(SignInForm formInputs)
        {
            throw new NotImplementedException();
        }

        public void SignOut(string id)
        {
            throw new NotImplementedException();
        }

        public void SignUp(SignUpForm formInputs)
        {
            var user = new Customer()
            {
                FirstName = formInputs.FirstName,
                LastName = formInputs.LastName,
                Email = formInputs.Email,
                AddressLine = formInputs.AddressLine,
                ZipCode = formInputs.ZipCode,
                City = formInputs.City
            };

            var _user = _customerManager.CreateCustomer(user, formInputs.Password);

            if (_user != null)
                Console.WriteLine($"Användaren {_user.DisplayName} skapades.");
            else
                Console.WriteLine("Något gick fel när användaren skulle skapas.");
        }
    }
}
