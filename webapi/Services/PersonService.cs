using System;
using System.Collections.Generic;
using webapi.Model;
using webapi.Repository;

namespace webapi
{
    public interface IPersonService
    {
        bool AddPerson(string name, int age);
        List<Person> GetPersons();
    }

    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public bool AddPerson(string name, int age)
        {
            try
            {
                _personRepository.AddPerson(name, age);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Person> GetPersons()
        {
            return _personRepository.GetPeople();
        }
    }
}
