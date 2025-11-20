using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookSmart.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public string RequestedTitle { get; set; }
        public string RequestedAuthor { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }

        public Order() { }

        public Order(
            string orderId,
            Customer customer,
            string requestedTitle,
            string requestedAuthor,
            DateTime orderDate,
            DateTime estimatedArrivalDate)
        {
            OrderId = orderId;
            Customer = customer;
            RequestedTitle = requestedTitle;
            RequestedAuthor = requestedAuthor;
            OrderDate = orderDate;
            EstimatedArrivalDate = estimatedArrivalDate;
        }

        public override string ToString()
        {
            return $"{RequestedTitle} by {RequestedAuthor} — ETA: {EstimatedArrivalDate:d}";
        }
    }
}
