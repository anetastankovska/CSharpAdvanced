using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Classes
{
    public class Invoice : IInvoice
    {
        public ICompany Company { get; set; }
        public IUser User { get; set; }
        public long InvoiceNumber { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DueDate { get; set; }
        public string IsInvoicePaid { get; set; }

        public Invoice(ICompany company, IUser user, int amount, DateTime dateOfIssue, DateTime dueDate, string isPaid)
        {
            Company = company;
            User = user;
            Amount = amount;
            DateOfIssue = dateOfIssue;
            DueDate = dueDate;
            IsInvoicePaid = isPaid;
        }
        public Invoice(IUser user, int amount, DateTime dateOfIssue, DateTime dueDate, string isPaid)
        {
            User = user;
            Amount = amount;
            DateOfIssue = dateOfIssue;
            DueDate = dueDate;
            IsInvoicePaid = isPaid;
        }

        public Invoice(int amount, DateTime dateOfIssue, DateTime dueDate, string isPaid)
        {
            Amount = amount;
            DateOfIssue = dateOfIssue;
            DueDate = dueDate;
            IsInvoicePaid = isPaid;
        }

        public override string ToString()
        {
            return $"{Company} - {Amount}. Date of issue {DateOfIssue.ToShortDateString()}, Due Date: {DueDate.ToShortDateString()} - {IsInvoicePaid}";
        }
    }
}
