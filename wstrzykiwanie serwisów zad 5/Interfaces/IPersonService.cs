using wstrzykiwanie_serwisów_zad_5.Models;
using wstrzykiwanie_serwisów_zad_5.ViewModels.Person;

namespace wstrzykiwanie_serwisów_zad_5.Interfaces
{
    
        public interface IPersonService
        {
            ListPersonForListVM GetPeopleForList();
            void AddEntry(Person p);
        List<Person> GetAllEntiresFromToday();


        List<Person> GetAllEntires();
        }

    
}
