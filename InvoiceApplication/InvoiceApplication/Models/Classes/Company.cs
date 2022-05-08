using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Company : ICompany
    {
        public string Name { get; set; }
        public List<IInvoice> Invoices { get; set; }
        public IAdmin Admin { get; set; }

        public Company(string name, IAdmin admin)
        {
            Name = name;
            Invoices = new List<IInvoice>();
            Admin = admin;
        }
        public Company(string name)
        {
            Name = name;
            Invoices = new List<IInvoice>();
        }

        public void AddInvoice(IInvoice invoice)
        {
            invoice.Company = this;
            Invoices.Add(invoice);
        }

        public void AssignAdmin(IAdmin admin)
        {
            admin.Company = this;
            Admin = admin;
        }
    }
}
