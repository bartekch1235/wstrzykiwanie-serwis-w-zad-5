using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wstrzykiwanie_serwisów_zad_5.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public string Data { get; set; }
        [Required]
        public int Year { get; set; }
        public virtual ICollection<Address>? Addresses {get; set;}
        public ICollection<PersonGroup>? PersonGroups { get; set; }
        public bool IsActive { get; set; }
        public Person (string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsActive = true;
            Data = DateTime.Now.ToString("d");
        }
        public Person(string FirstName, string LastName,bool isActive)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsActive = true;
            Data = DateTime.Now.ToString("d");
        }
        public Person()
        {

        }
        public string FullName()
        {
            return FirstName + " "+LastName;
        }
        public string Przestepca()
        {
            if (Year % 4 == 0)
                return " przestepca";
            return " ------";
        }
    }

}
