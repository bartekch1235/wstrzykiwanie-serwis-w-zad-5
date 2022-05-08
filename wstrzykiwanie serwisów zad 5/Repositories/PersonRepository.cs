using wstrzykiwanie_serwisów_zad_5.Data;
using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.Models;

namespace wstrzykiwanie_serwisów_zad_5.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly PeopleContext _context;
        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetAllActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }
        public void AddPerson(Person p)
        {
            
            _context.Person.Add(p);
            _context.SaveChanges();
        }
        public List<Person> GetAllEntires()
        {
            List<Person> ludzie=new List<Person>();
            foreach (Person p in _context.Person)
            {
                ludzie.Add(p);
            }
            return ludzie;

        }
        public List<Person> GetAllEntiresFromToday()
        {
            DateTime dateTime = DateTime.Now;
            List<Person> ludzie = new List<Person>();
            foreach (Person p in _context.Person)
            {
                dateTime = Convert.ToDateTime(p.Data);
                if (dateTime.Day==DateTime.Today.Day)
                    ludzie.Add(p);
            }
            return ludzie;

        }


    }

}
