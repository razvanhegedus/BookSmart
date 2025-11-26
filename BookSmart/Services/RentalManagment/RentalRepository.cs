using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.RentalManagment
{
    public class RentalRepository : IRentalRepository
    {
        private readonly string rentalsPath;

        public RentalRepository()
        {
            var projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            rentalsPath = Path.Combine(projectRoot, "Data", "rentals.txt");
        }


        public async Task<List<Rental>> LoadRentalsAsync(List<Book> books)
        {
            var rentals = new List<Rental>();

            if (!File.Exists(rentalsPath))
                return rentals;

            var lines = await File.ReadAllLinesAsync(rentalsPath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 6)
                    continue;

                var book = books.FirstOrDefault(b => b.Id == parts[2]);
                if (book == null) continue;

                rentals.Add(new Rental(
                    parts[0],
                    new Customer(parts[1]),
                    book,
                    DateTime.Parse(parts[3]),
                    DateTime.Parse(parts[4]))
                {
                    ReturnDate = string.IsNullOrWhiteSpace(parts[5]) ? null : DateTime.Parse(parts[5])
                });
            }

            return rentals;
        }

        public async Task SaveRentalsAsync(List<Rental> rentals)
        {
            var lines = rentals.Select(r =>
                $"{r.RentalId};{r.Customer.Name};{r.Book.Id};{r.StartDate};{r.DueDate};{(r.ReturnDate.HasValue ? r.ReturnDate.Value.ToString() : "")}"
            );

            await File.WriteAllLinesAsync(rentalsPath, lines);
        }
    }
}
