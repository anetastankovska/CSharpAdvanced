using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class Invoice : IInvoice
    {
        public ICompany Company { get; set; }
        public long InvoiceNumber { get; set; }
        public int Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateOfIssue { get; set; }

        public Invoice(ICompany company, int amount, DateTime dueDate, DateTime dateOfIssue)
        {
            Company = company;
            Amount = amount;
            DueDate = dueDate;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"{Company} - {Amount}. Date of issue {DateOfIssue.Date}, Due Date: {DueDate.Date}";
        }
    }
}
