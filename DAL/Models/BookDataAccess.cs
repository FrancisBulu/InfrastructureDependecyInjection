using BOL;
using BOL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BookDataAccess : IBookDataAccess
    {
        private List<Book> _books;

        public BookDataAccess()
        {
            _books = new List<Book>()
            {
                new Book {Id = 1, Title = "C# Advanced", Description = "C# Advanced 3 tier apps", Author="Kenan Kurda", Price = 38.5m},
                new Book {Id = 2, Title = "SQL Server", Description = "Database Adminisration", Author="Eric Hoffman", Price = 42.5m},
                new Book {Id = 3, Title = "MVC Core", Description = "Web development in MS", Author="Murach books", Price = 47.5m},
                new Book {Id = 4, Title = "Dapper ORM", Description = "ORM for .NET Developers", Author="Stack Overflow", Price = 39.55m},
                new Book {Id = 5, Title = "Entity Framework", Description = "Advanced Entity Framework Core", Author="Apress", Price = 47.5m}
            };
        }
        public Book GetBookByID(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
    }
}
