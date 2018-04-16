using System.Collections.Generic;
using System.Linq;
using webapi.Model;

namespace webapi.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        void AddPerson(string name, int age);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly PersonContext _dbContext;

        public PersonRepository(PersonContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddPerson(string name, int age)
        {
            _dbContext.Persons.Add(new Person { Name = name, Age = age });
            _dbContext.SaveChanges();
        }

        public List<Person> GetPeople()
        {
            return _dbContext.Persons.ToList();
        }
    }
}
