using System.Collections.Generic;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.RentalManagment
{
    public interface IRentalRepository
    {
        Task<List<Rental>> LoadRentalsAsync(List<Book> books);
        Task SaveRentalsAsync(List<Rental> rentals);
    }
}

