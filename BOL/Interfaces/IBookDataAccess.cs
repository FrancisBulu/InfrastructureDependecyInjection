using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Interfaces
{
    public interface IBookDataAccess
    {
        List<Book> GetBooks();
        Book GetBookByID(int id);
    }
}
