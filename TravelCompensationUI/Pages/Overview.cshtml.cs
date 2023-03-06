using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TravelCompensationUI.Pages.NewFolder
{
    using NodaTime;

    using TravelAllowance;
    using TravelAllowance.Model;

    public class OverviewModel : PageModel
    {
        private readonly ITravelCompensationService compensationService;
        public OverviewModel(ITravelCompensationService compensationService)
        {
            this.compensationService = compensationService;
        }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Date { get; set; }

        [BindProperty]
        public TravelCompensationResult Compensation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string date, string name)
        {
            Name = name;
            Date = date;

            if(DateTime.TryParse(date, out DateTime parsedDate))
            {
                var result = await compensationService.GetOverViewForUserOfMonth(name, new YearMonth(parsedDate.Year, parsedDate.Month));
                Compensation = result;
            }

            return Page();
        }
    }
}
