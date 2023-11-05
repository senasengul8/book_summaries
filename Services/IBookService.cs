using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfrontend.Data;

namespace myfrontend.Data.Services
{
    public interface IBookService
    {

        List<Book>   GetAllBooks();
        Book GetBookByID(int id);
        void UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);


    }
}