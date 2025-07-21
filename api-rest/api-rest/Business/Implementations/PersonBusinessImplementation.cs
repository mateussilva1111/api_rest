using api_rest.Model;
using api_rest.Model.Context;
using api_rest.Repository;

namespace api_rest.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _personRepository;

        public PersonBusinessImplementation(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public Person Create(Person person)
        {
            try
            {
                _personRepository.Create(person);
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        public void Delete(long id)
        {

            _personRepository.Delete(id);

        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(int id)
        {
            return _personRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}
