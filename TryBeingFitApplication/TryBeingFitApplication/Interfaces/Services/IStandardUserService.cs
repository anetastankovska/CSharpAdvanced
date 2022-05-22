using Interfaces;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IStandardUserService : IUserService
    {
        public List<IStandardUser> StandardUsers { get; set; }

        public IStandardUser Register(string firstname, string lastname, string username, string password);
        public string GetAccount(IStandardUser user);
        public IPremiumUser UpgradeToPremium(IStandardUser standardUser);
    }
}
