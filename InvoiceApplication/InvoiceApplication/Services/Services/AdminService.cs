using Data;
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

        public List<IInvoice> GetAllInvoices(ICompany company)
        {
            ICompany cmp = Repository.Companies.FirstOrDefault(x => x == company);
            if (cmp != null)
            {
                return cmp.Invoices;
            }
            return new List<IInvoice>();
        }

        public string ShowInvoices(ICompany company)
        {
            List<IInvoice> invoices = GetAllInvoices(company);
            return string.Join("\n", invoices.Select(x => $"{invoices.IndexOf(x) + 1}. {x}"));
        }
    }
}
