using ContosoModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class PersonRepository: IRepository<Person>
    {

        public void Create(Person person)
        {
            using (var db = new ContosoDBContext())
            {
                db.Person.Add(person);
                db.SaveChanges();
            }
        }

        public List<Person> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                var people = db.Person.ToList();
                return people;
            }
        }

        public Person GetById(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var person = db.Person.Where(d => d.Id == id).FirstOrDefault();
                return person;
            }
        }

        public void Update(Person person)
        {
            using (var db = new ContosoDBContext())
            {
                db.Person.Attach(person);
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public Person Details(int id)
        {
            using (var db = new ContosoDBContext())
            {
                var person = db.Person.Where(d => d.Id == id).FirstOrDefault();
                return person;
            }
        }
    }
}
