using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController(AppDbContext appDbContext) : ControllerBase
    {
        private readonly AppDbContext _appDbContext = appDbContext;


        [HttpPost] // Equivalente ao Create
        public async Task<IActionResult> AddBook([FromBody]Book book)
        {
            if(!ModelState.IsValid) { return BadRequest(ModelState); }

            _appDbContext.Books.Add(book);
            await _appDbContext.SaveChangesAsync();

            return Created("Livro adicionado com sucesso!", book);
        }

        [HttpGet] // Equivalente ao Read
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _appDbContext.Books.ToListAsync();

            return Ok(books);
        }

        [HttpGet("{id}")] // Equivalente ao Read
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _appDbContext.Books.FindAsync(id);
            if (book == null) { return NotFound("Livro não encontrado!"); }

            return Ok(book);
        }

        [HttpPut("{id}")] // Equivalente ao Update
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = await _appDbContext.Books.FindAsync(id);
            if (book == null) { return NotFound("Livro não encontrado!"); }

            _appDbContext.Entry(book).CurrentValues.SetValues(updatedBook);
            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, book);
        }

        [HttpDelete("{id}")] // Equivalente ao Delete
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _appDbContext.Books.FindAsync(id);
            if (book == null) { return NotFound("Livro não encontrado!"); }

            _appDbContext.Books.Remove(book);
            await _appDbContext.SaveChangesAsync();

            return Ok("Livro deletado com sucesso!");
        }
    }
}