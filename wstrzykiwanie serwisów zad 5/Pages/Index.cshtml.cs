using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.ViewModels.Person;

namespace wstrzykiwanie_serwisów_zad_5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;
        public ListPersonForListVM Records { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
            Records = _personService.GetPeopleForList();
        }
    }
}