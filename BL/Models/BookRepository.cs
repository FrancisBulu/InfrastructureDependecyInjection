using BOL;
using BOL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class BookRepository : IBookDataAccess
    {
        private readonly IBookDataAccess _bookData;
        public BookRepository(IBookDataAccess bookData)
        {
            _bookData = bookData;
        }
        public Book GetBookByID(int id)
        {
            return _bookData.GetBookByID(id);
        }
        public List<Book> GetBooks()
        {
            return _bookData.GetBooks();
        }
    }
}
