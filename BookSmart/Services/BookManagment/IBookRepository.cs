using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.BookManagment
{
    public interface IBookRepository
    {
        Task<List<Book>> LoadBooksAsync();
        Task SaveBooksAsync(List<Book> books);
        Book? FindBookByTitle(List<Book> books, string title);
        Book? FindBookById(List<Book> books, string id);
    }
}

