using api_rest.Model;

namespace api_rest.Service
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);

        Person FindById(int id);

        List<Person> FindAll ();
    }
}
