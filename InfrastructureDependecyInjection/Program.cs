using BL.Models;
using BOL;
using BOL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureDependecyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookDataAccess bookRepository = new BookRepository(new BookDataAccess());
            Console.Clear();
            string separator = new string('*', 30);
            var books = bookRepository.GetBooks();

            Console.WriteLine();
            Console.WriteLine("All books");
            Console.WriteLine();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}. \t{book.Title} \t{book.Description} \t{book.Author}");
            }
            while (true)
            {
                Console.Write("Please enter your command [D/d for details] ");
                string command = Console.ReadLine();

                switch (command.ToUpper())
                {
                    case "D":
                        try
                        {
                            Console.WriteLine("Please enter the id of the book to be displayed");
                            string id = Console.ReadLine();
                            var book = bookRepository.GetBookByID(int.Parse(id));
                            Console.WriteLine();
                            Console.WriteLine(separator);
                            Console.WriteLine($"Title: {book.Title}");
                            Console.WriteLine($"Description: {book.Description}");
                            Console.WriteLine($"Author: {book.Author}");
                            Console.WriteLine(separator);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please check your command");
                        }
                        break;
                    case "E": //om het programma te stoppen
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
