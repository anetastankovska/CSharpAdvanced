using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Admin : BaseUser, IAdmin
    {
        public ICompany Company { get; set; }

        public Admin (string firstname, string lastname, string username, string password, ICompany company)
            : base(firstname, lastname, username, password)
        {
            Company = company;
        }
    }
}
