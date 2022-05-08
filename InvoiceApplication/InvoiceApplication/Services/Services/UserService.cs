using Models.Classes;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UserService : IUserService
    {
        public IUser CurrentUser { get; set; }
        public List<IUser> Users { get; set; } = new List<IUser>();

        public int CheckBalance()
        {
            return CurrentUser.CurrentBalance;
        }

        public int CashDeposit (int deposit)
        {
            CurrentUser.CurrentBalance += deposit;
            return CurrentUser.CurrentBalance;
        }

        public string ShowAllInvoices()
        {
            List<string> allUserInvoices = CurrentUser.Invoices.Select(x => $"{CurrentUser.Invoices.IndexOf(x) + 1}. {x}").ToList();
            return string.Join("\n", allUserInvoices); 
        }

        public List<IInvoice> GetUnpaidInvoices()
        {
            List<IInvoice> unpaidInvoices = CurrentUser.Invoices.Where(x => x.IsInvoicePaid == false).ToList();
            return unpaidInvoices;
        }

        public string ShowUnpaidInvoices()
        {
            List<IInvoice> unpaidInvoices = GetUnpaidInvoices();
            string result = string.Join("\n", unpaidInvoices.Select(x => $"{unpaidInvoices.IndexOf(x) + 1}. {x}").ToList());
            return result;
        }

        public IInvoice PickInvoice(int selection)
        {
            List<IInvoice> unpaidInvoices = GetUnpaidInvoices();
            return unpaidInvoices[selection - 1];
        }

        public void PayInvoice(IInvoice invoice)
        {
            invoice.IsInvoicePaid = true;
            CurrentUser.CurrentBalance -= invoice.Amount;
        }
    }
}
