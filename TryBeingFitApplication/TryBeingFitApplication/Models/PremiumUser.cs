using Interfaces;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PremiumUser : User, IPremiumUser
    {
        public bool CompletedLiveTraining { get; set; } = false;
        public PremiumUser()
        {

        }
        public PremiumUser(string firstname, string lastname, string username, string password, bool completedLiveTraining)
            : base(firstname, lastname, username, password)
        {
            CompletedLiveTraining = completedLiveTraining;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
