using api_rest.Data.Coverter.Implementation;
using api_rest.Data.VO;
using api_rest.Model;
using api_rest.Repository;

namespace api_rest.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _personRepository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
            _converter = new PersonConverter();
        }
        public PersonVO Create(PersonVO person)
        {
            try
            {
                var personEntity = _converter.Parse(person);
                personEntity = _personRepository.Create(personEntity);
                return _converter.Parse(personEntity);
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

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_personRepository.FindAll());
        }

        public PersonVO FindById(int id)
        {
            return _converter.Parse(_personRepository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {

            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
