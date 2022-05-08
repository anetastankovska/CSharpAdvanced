using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class User : BaseUser, IUser
    {
        public int CurrentBalance { get; set; }
        public List<IInvoice> Invoices { get; set; }

        public User(string firstname, string lastname, string username, string password, int currentBalance)
            : base(firstname, lastname, username, password)
        {
            CurrentBalance = currentBalance;
            Invoices = new List<IInvoice>();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
