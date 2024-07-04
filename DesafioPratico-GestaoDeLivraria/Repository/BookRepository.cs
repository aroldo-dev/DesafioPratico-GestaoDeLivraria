using DesafioPratico_GestaoDeLivraria.Contracts;
using DesafioPratico_GestaoDeLivraria.Models;

namespace DesafioPratico_GestaoDeLivraria.Repository
{
    public class BookRepository
    {

        private readonly List<Book> _books = [];

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book? GetBook(int id)
        {
            return _books.FirstOrDefault(book => book.Id == id);
        }

        public Book CreateBook(BookCreateDto dto)
        {
            Book book = new()
            {
                Id = _books.Count + 1,
                Title = dto.Title,
                Author = dto.Author,
                Genre = dto.Genre,
                Price = dto.Price,
                Quantity = dto.Quantity
            };
            _books.Add(book);
            return book;
        }

        public Book? UpdateBook(int id, BookUpdateDto book)
        {
            Book? bookToUpdate = _books.FirstOrDefault(book => book.Id == id);
            if (bookToUpdate == null)
            {
                return null;
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Genre = book.Genre;
            bookToUpdate.Price = book.Price;
            bookToUpdate.Quantity = book.Quantity;

            return bookToUpdate;
        }

        public void DeleteBook(int id)
        {
            Book? book = _books.FirstOrDefault(book => book.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

    }
}
