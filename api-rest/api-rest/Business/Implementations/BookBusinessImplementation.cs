using api_rest.Data.Coverter.Implementation;
using api_rest.Data.VO;
using api_rest.Model;
using api_rest.Repository;

namespace api_rest.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            try
            {
                var bookEntity = _converter.Parse(book);
                bookEntity = _bookRepository.Create(bookEntity);
                return _converter.Parse(bookEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {

            _bookRepository.Delete(id);

        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_bookRepository.FindAll());
        }

        public BookVO FindById(int id)
        {
            return _converter.Parse(_bookRepository.FindById(id));
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _bookRepository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }
    }
}
