using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BookSmart.Models
{
    public class Rental
    {
        public string RentalId { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Rental() { }

        public Rental(string rentalId, Customer customer, Book book, DateTime startDate, DateTime dueDate)
        {
            RentalId = rentalId;
            Customer = customer;
            Book = book;
            StartDate = startDate;
            DueDate = dueDate;
        }

        public bool IsOverdue(DateTime now)
        {
            return !ReturnDate.HasValue && now.Date > DueDate.Date;
        }

        public int GetOverdueDays(DateTime now)
        {
            if (!IsOverdue(now)) return 0;
            return (now.Date - DueDate.Date).Days;
        }
    }
}
