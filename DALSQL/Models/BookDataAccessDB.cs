using BOL;
using BOL.Interfaces;
using BOL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALSQL.Models
{
    public class BookDataAccessDB : IBookDataAccess
    {
        private List<Book> _books;
        public BookDataAccessDB()
        {

        }
        public Book GetBookByID(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("Books")))
            {
                //var sql = $"Select * from Book where id = {id}";
                //var output = connection.QuerySingle<Book>(sql);
                //return output;

                var book = connection.Query<Book>("GetBookById", new { id = id },
                    commandType: CommandType.StoredProcedure).SingleOrDefault();

                return book;
            }
        }

        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new SqlConnection(Helper.Constr("Books")))
            {
                //var output = connection.Query<Book>("select * from Book").ToList();
                //return output;      

                var books = connection.Query<Book>("GetAllBooks",
                    commandType: CommandType.StoredProcedure).ToList();

                return books;
            }
        }
    }
}
