using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        public IUser CurrentUser { get; set; }
        public List<IUser> Users { get; set; }

        public int CheckBalance();
        public int CashDeposit(int deposit);
        public string ShowAllInvoices();
        public List<IInvoice> GetUnpaidInvoices();
        public string ShowUnpaidInvoices();
        public IInvoice PickInvoice(int selection);
        public void PayInvoice(IInvoice invoice);
    }
}
