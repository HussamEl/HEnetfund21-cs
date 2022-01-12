using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Models
{
    internal class Customer
    {
        private string _email;


        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get { return _email; } set { _email = value.ToLower(); } } 
        public int? Phone { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
        public string Address { get { return $"{AddressLine}, {ZipCode} {City}"; } }

        private string Hash { get; set; }
        private string Salt { get; set; }

        public void CreatePassword(string password)
        {
            Hash = password;
            Salt = password;
        }

        public bool ValidatePassword(string password)
        {
            if (Hash == password)
                return true;
            return false;
        }
        
    }
}
