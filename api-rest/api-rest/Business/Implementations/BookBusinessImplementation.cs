using api_rest.Model;
using api_rest.Repository;

namespace api_rest.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _bookRepository;

        public BookBusinessImplementation(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public Book Create(Book book)
        {
            try
            {
                _bookRepository.Create(book);
            }
            catch (Exception)
            {
                throw;
            }
            return book;
        }

        public void Delete(long id)
        {

            _bookRepository.Delete(id);

        }

        public List<Book> FindAll()
        {
            return _bookRepository.FindAll();
        }

        public Book FindById(int id)
        {
            return _bookRepository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}
