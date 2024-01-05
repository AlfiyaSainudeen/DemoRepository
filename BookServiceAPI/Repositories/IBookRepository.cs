using BookServiceAPI.Models;

namespace BookServiceAPI.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(int BookId);
        Book GetBook(int BookId);
        List<Book> GetAll();
        List<Book> GetBookByAuthor(string Author);
        List<Book> GetBookByLang(string Lang);
        List<Book> GetBookByName(string BookName);
        List<Book> GetBookById(int BookId);
        List<Book> GetBookByYear(int year);
    }
}
