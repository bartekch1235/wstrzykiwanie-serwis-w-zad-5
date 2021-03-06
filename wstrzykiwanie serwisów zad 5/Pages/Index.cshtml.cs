using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.ViewModels.Person;
using wstrzykiwanie_serwisów_zad_5.Repositories;
using wstrzykiwanie_serwisów_zad_5.Models;

namespace wstrzykiwanie_serwisów_zad_5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;
        public List<Person>Records { get; set; }
        [BindProperty]
        public Person Person { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
            Records = _personService.GetAllEntiresFromToday();
        }
      
        public IActionResult OnPost()
        {
            Person.Data = DateTime.Now.ToString();
            Person.IsActive = true;
            _personService.AddEntry(Person);
            


            return RedirectToPage("/privacy");
        }
    }
}