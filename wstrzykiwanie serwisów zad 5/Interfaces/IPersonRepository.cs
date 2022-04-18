using wstrzykiwanie_serwisów_zad_5.Models;

namespace wstrzykiwanie_serwisów_zad_5.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllActivePeople();
    }

}
