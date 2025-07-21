using api_rest.Model;

namespace api_rest.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);

        Person FindById(int id);

        List<Person> FindAll ();
    }
}
