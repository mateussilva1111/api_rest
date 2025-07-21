using api_rest.Data.VO;
using api_rest.Model;

namespace api_rest.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO Update(PersonVO person);

        void Delete(long id);

        PersonVO FindById(int id);

        List<PersonVO> FindAll ();
    }
}
