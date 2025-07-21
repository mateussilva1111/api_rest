using api_rest.Model;

namespace api_rest.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);

        Book FindById(int id);

        List<Book> FindAll();
    }
}
