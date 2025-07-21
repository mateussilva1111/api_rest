using api_rest.Data.VO;
using api_rest.Model;

namespace api_rest.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);

        BookVO FindById(int id);

        List<BookVO> FindAll();
    }
}
