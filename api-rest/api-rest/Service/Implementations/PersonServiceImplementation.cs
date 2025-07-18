using api_rest.Model;
using api_rest.Model.Context;

namespace api_rest.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MysqlContext _context;

        public PersonServiceImplementation(MysqlContext context)
        {
            _context = context;
        }
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ) 
            {
                throw ;
            }
            return person; 
        }

        public void Delete(long id)
        {
            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Person.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
           return _context.Person.ToList();
        }

        public Person FindById(int id)
        {
            return _context.Person.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id))return new Person(); 
            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }

        private bool Exists(long id)
        {
            return _context.Person.Any(p => p.Id.Equals(id));
        }
    }
}
