using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Events.Entities
{
    public class Market
    {
        public delegate void PromotionSender(ProductType productType, string name);

        public event PromotionSender PromotionSenderEvent;

        public ProductType CurrentProductType { get; set; }

        public List<string> Emails { get; set; }

        public string Name { get; set; }

        public Market()
        {
            Emails = new List<string>();
        }

        public void SubscribeToPromotion(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent += eventHandler;
            Emails.Add(email);
        }

        public void Send()
        {
            PromotionSenderEvent(CurrentProductType, Name);
        }

        public void Unsubscribe(PromotionSender eventHandler, string email)
        {
            PromotionSenderEvent -= eventHandler;
            string emailToDelete = Emails.FirstOrDefault(x => x == email);
            Emails.Remove(emailToDelete);
        }

    }

    public enum ProductType
    {
        Food,
        Cosmetics,
        Electronic,
        Other
    }
}
