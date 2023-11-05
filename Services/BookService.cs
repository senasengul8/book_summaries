namespace myfrontend.Data.Services
{

    public class BookService : IBookService
    {
        public List<Book> GetAllBooks()
        {


            return Data.Books.ToList();
            throw new NotImplementedException();
        }

        public Book GetBookByID(int id)
        {
            return Data.Books.FirstOrDefault(n => n.Id == id);
            throw new NotImplementedException();
        }

        public void UpdateBook(int id, Book newBook)
        {

            var oldBook = Data.Books.FirstOrDefault(n => n.Id == id);
            if (oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Rate = newBook.Rate;
                oldBook.DateRead = newBook.DateRead;
                oldBook.DateStart = newBook.DateStart;

            }
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {

            var book = Data.Books.FirstOrDefault((n => n.Id == id));
            Data.Books.Remove(book);
            throw new NotImplementedException();
        }

        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
            throw new NotImplementedException();
        }
    }
}
