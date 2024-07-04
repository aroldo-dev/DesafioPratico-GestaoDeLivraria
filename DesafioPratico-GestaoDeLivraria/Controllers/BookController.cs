using DesafioPratico_GestaoDeLivraria.Contracts;
using DesafioPratico_GestaoDeLivraria.Models;
using DesafioPratico_GestaoDeLivraria.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPratico_GestaoDeLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private BookRepository _bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this._bookRepository.GetBooks());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book? book = this._bookRepository.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(BookCreateDto dto)
        {
            Book book = this._bookRepository.CreateBook(dto);
            return Ok(book);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, BookUpdateDto dto)
        {
            this._bookRepository.UpdateBook(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            this._bookRepository.DeleteBook(id);
            return Ok();
        }   

    }
}
