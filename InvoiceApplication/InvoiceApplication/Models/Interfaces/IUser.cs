using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IUser : IBaseUser
    {
        public int CurrentBalance { get; set; }
        public List<IInvoice> Invoices { get; set; }
    }
}
