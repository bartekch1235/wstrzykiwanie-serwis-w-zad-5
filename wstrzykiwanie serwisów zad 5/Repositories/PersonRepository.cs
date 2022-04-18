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

    }

}
