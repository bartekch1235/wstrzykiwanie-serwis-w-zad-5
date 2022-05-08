using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.Models;
using wstrzykiwanie_serwisów_zad_5.ViewModels.Person;

namespace wstrzykiwanie_serwisów_zad_5.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }
        public ListPersonForListVM GetPeopleForList()
        {
            var people = _personRepo.GetAllActivePeople();
            ListPersonForListVM result = new
            ListPersonForListVM();
            result.People = new List<PersonForListVm>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVm()
                {
                    Id = person.Id,
                    FullName = person.FirstName + " " + person.LastName
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }
        public void AddEntry(Person p)
        {
            _personRepo.AddPerson(p);
        }
        public List<Person> GetAllEntiresFromToday()
            {
            return _personRepo.GetAllEntiresFromToday();
            }
        public List<Person> GetAllEntires()
        {
            return _personRepo.GetAllEntires();
        }
    }

}
