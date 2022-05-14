using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils
{
    public static class Helpers
    {
        public static List<string> RegisterNewUser()
        {
            string firstname = Validations.ValidateFirstName();
            string lastname = Validations.ValidateLastName();
            string username = Validations.ValidateUsername();
            string password = Validations.ValidatePassword();
            return new List<string> { firstname, lastname, username, password};
        }

        
    }
}
