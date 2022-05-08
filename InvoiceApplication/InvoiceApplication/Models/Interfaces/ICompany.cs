using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ICompany
    {
        public string Name { get; set; }
        public List<IInvoice> Invoices { get; set; }
        public IAdmin Admin { get; set; }
    }
}
