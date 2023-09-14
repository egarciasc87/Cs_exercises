using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Model;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("bookAPI")]
    public class BookCrontroller : ControllerBase
    {
        [HttpGet]
        [Route("listBook")]
        public dynamic listBook()
        {
            //Read book from database
            List<Book> list = new List<Book>()
            {
                new Book("the old man and the sea", "drama", "E. Hemingway"),
                new Book("la ciudad y los perros", "drama", "M. Vargas")
            };
            
            return list;
        }

        [HttpPost]
        [Route("saveBook")]
        public dynamic saveBook(Book book)
        {
            //Save book on database

            return new
            {
                success = true,
                message = "Book saved.",
                result = book
            }; ;
        }

        [HttpDelete]
        [Route("deleteBook")]
        public dynamic deleteBook(Book book)
        {
            //Request
            //Delete book from database

            return new
            {
                success = true,
                message = "Book deleted.",
                result = book
            };
        }
    }
}
