using ContosoData;
using ContosoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class PersonService
    {

        public List<Person> GetAllPeople()
        {
            PersonRepository repository = new PersonRepository();
            var person = repository.GetAll();
            return person;
        }

        public void CreatePerson(Person person)
        {
            PersonRepository repository = new PersonRepository();
            repository.Create(person);

        }
        public Person GetPersonById(int Id)
        {
            PersonRepository repository = new PersonRepository();
            return repository.GetById(Id);
        }

        public void UpdatePerson(Person person)
        {
            PersonRepository repository = new PersonRepository();
            repository.Update(person);
        }
    }
}
