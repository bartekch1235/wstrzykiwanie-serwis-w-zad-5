namespace wstrzykiwanie_serwisów_zad_5.Models
{
    public class PersonGroup
    {
        public int PersonId { get; set; } //klucz obcy do Person
        public Person Person { get; set; }
        public int GroupId { get; set; } //klucz obcy do Group
        public Group Group { get; set; }
    }

}
