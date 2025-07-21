using api_rest.Model;

namespace api_rest.Repository
{
    public interface IBookRepository
    {
        Book Create(Book books);

        Book Update(Book books);

        void Delete(long id);

        Book FindById(long id);

        List<Book> FindAll();

        bool Exists(long id);
    }
}
