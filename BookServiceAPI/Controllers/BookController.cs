using BookServiceAPI.Models;
using BookServiceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        [HttpGet,Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {

                List<Book> books = bookRepository.GetAll();
                return StatusCode(200, books);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetBookById/{id}")]
        public IActionResult GetBook(int BookId)
        {
            try
            {
                Book book = bookRepository.GetBook(BookId);
                if (book != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(405);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);

            }
        }
        [HttpGet, Route("GetBookByAuthor/{author}")]

        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByAuthor(author));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBookByYear/{year}")]

        public IActionResult GetBookByYear(int year)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByYear(year));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBookByLang/{lang}")]

        public IActionResult GetBookByLang(string lang)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByLang(lang));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBookByName/{bookname}")]

        public IActionResult GetBookByName(string bookname)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByName(bookname));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
       
        [HttpPost,Route("AddBook")]
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.Add(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpPut("UpdateBook")]
        public IActionResult Update(Book book)
        {
            try
            {
                bookRepository.Update(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult Delete(int  BookId)
        {
            try
            {
                bookRepository.Delete(BookId);
                return StatusCode(200, "book deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
