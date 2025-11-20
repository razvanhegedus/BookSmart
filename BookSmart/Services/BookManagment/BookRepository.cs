using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.BookManagment
{
    public class BookRepository : IBookRepository
    {
        private readonly string booksPath;

        public BookRepository()
        {
            booksPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "books.txt");
        }

        public async Task<List<Book>> LoadBooksAsync()
        {
            var list = new List<Book>();

            if (!File.Exists(booksPath))
                return list;

            var lines = await File.ReadAllLinesAsync(booksPath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 5)
                    continue;

                list.Add(new Book(
                    parts[0],
                    parts[1],
                    parts[2],
                    bool.Parse(parts[3]),
                    decimal.Parse(parts[4], CultureInfo.InvariantCulture)
                ));
            }

            return list;
        }

        public async Task SaveBooksAsync(List<Book> books)
        {
            var lines = books.Select(b =>
                $"{b.Id};{b.Title};{b.Author};{b.IsAvailable.ToString().ToLower()};{b.DailyRentalPrice.ToString(CultureInfo.InvariantCulture)}"
            );

            await File.WriteAllLinesAsync(booksPath, lines);
        }

        public Book? FindBookByTitle(List<Book> books, string title)
        {
            return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public Book? FindBookById(List<Book> books, string id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}
