using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IInvoice
    {
        public ICompany Company { get; set; }
        public IUser User { get; set; }
        public long InvoiceNumber { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsInvoicePaid { get; set; }

    }
}
