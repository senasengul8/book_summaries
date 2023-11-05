using Microsoft.AspNetCore.Mvc;
using myfrontend.Data;
using myfrontend.Data.Services;

namespace myfrontend.Controllers
{
    [Route(("api/[controller]"))]
    public class BooksController : Controller
    {
        private IBookService _service;

        public BooksController(IBookService service)
        {

            _service = service;
            //create 
        }


        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _service.AddBook(book);
            return Ok("added");
        }

        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {

            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {

            _service.UpdateBook(id, book);
            return Ok(book);
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {

            _service.DeleteBook(id);
            return Ok();
        }

        //GETSINGLE
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookByID(id);
            return Ok(book);

        }
    }
    






}
        
    
    
    
