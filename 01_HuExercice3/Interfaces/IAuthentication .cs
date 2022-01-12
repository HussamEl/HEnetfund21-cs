using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Interfaces
{
    internal interface IAuthentication
    {
        void SignUp(string firstName, string lastName, string email, string password);
        string SingIn(string email, string password);
        void SIgnOut(string id);
    }
}
