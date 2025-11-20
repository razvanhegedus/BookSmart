using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmart.Models
{
    public class Book
    {
        public string Id { get; set; }              // unique ID
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }       // true if in stock
        public decimal DailyRentalPrice { get; set; }

        public Book() { }

        public Book(string id, string title, string author, bool isAvailable, decimal dailyRentalPrice)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
            DailyRentalPrice = dailyRentalPrice;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} | Available: {(IsAvailable ? "Yes" : "No")}";
        }
    }
}

