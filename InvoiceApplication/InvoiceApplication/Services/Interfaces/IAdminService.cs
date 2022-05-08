using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAdminService
    {
        public IAdmin CurrentAdmin { get; set; }
        public List<IAdmin> Admins { get; set; }
        public List<IInvoice> GetAllInvoices(ICompany company);
        public string ShowInvoices(ICompany company);
    }
}
