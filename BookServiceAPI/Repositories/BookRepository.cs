using BookServiceAPI.Models;

namespace BookServiceAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new List<Book>();
        public void Add(Book book)
        {
            try
            {
                books.Add(book);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int BookId)
        {
            try
            {
                foreach(var book in books)
                {
                    if(book.BookId==BookId)
                    {
                        books.Remove(book);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public Book GetBook(int BookId)
        {
            try
            {
                foreach(var book in books)
                {
                    if(book.BookId==BookId)
                    {
                        return book;
                    }
                }
                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByAuthor(string Author)
        {
            List<Book> bok = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.Author == Author)
                    {
                        bok.Add(book);
                    }
                }
                return bok;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookById(int BookId)
        {
            List<Book> bok = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.BookId == BookId)
                    {
                        bok.Add(book);
                    }
                }
                return bok;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByLang(string Lang)
        {
            List<Book> bok = new List<Book>();
            try
            {
                foreach(var book in books)
                {
                    if(book.Lang==Lang)
                    {
                        bok.Add(book);
                    }
                }return bok;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByName(string BookName)
        {
            List<Book> bok = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.BookName == BookName)
                    {
                        bok.Add(book);
                    }
                }
                return bok;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByYear(int year)
        {
            List<Book> bok = new List<Book>();
            try
            {
                foreach (var book in books)
                {
                    if (book.ReleaseYear==year)
                    {
                        bok.Add(book);
                    }
                }
                return bok;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Book book)
        {
            try
            {
                foreach(var item in books)
                {
                    if(item.BookId==book.BookId)
                    {
                        item.BookName = book.BookName;
                        item.Author = book.Author;
                        item.Publisher = book.Publisher;
                        item.Price = book.Price;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
