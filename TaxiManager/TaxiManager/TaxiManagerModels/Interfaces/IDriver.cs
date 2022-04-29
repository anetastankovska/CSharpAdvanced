using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IDriver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Shift Shift { get; set; }
        public ICar Car { get; set; }
        public string License { get; set; }
        DateTime LicenseExpiryDate { get; set; }
    }
}
