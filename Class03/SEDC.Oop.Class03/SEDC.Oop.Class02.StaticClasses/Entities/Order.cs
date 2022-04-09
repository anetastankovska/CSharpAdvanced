using SEDC.Oop.Class02.StaticClasses.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.StaticClasses.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public Order()
        {

        }

        public Order(int id, string title, string description, OrderStatus orderStatus)
        {
            Id = id;
            Title = title;
            Description = description;
            OrderStatus = orderStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Title)} - {StringUtils.CapitaliseFirstLetter(Description)}");
        }
    }

    public enum OrderStatus
    {
        Processing,
        Shipped,
        Delivered
    }
}
