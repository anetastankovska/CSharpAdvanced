using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AdminService : IAdminService
    {
        public List<IAdmin> Admins { get; set; } = new List<IAdmin>();

        public List<IInvoice> GetAllInvoices()
        {
            return null;
            //List<IInvoice> invoices = 
        }

        public string ShowInvoices()
        {
            return "";
        }

    }
}
