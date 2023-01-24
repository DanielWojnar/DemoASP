using DemoASP.Models;

namespace DemoASP.Services
{
    public interface IBookService
    {
        public Task<List<Book>> GetBooksAsync();
        public Task<Book> AddBookAsync(BookFormInput bookFormInput);
    }
}
