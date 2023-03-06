namespace TravelCompensationUI.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using TravelAllowance;

    public class IndexModel : PageModel
    {
        private LinkGenerator linkGenerator;
        private readonly ITravelCompensationService compensationService;

        public IndexModel(LinkGenerator linkGenerator, ITravelCompensationService compensationService)
        {
            this.linkGenerator = linkGenerator;
            this.compensationService = compensationService;
        }

        [BindProperty]
        public List<EmployeeRecord> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var employeeData = await compensationService.GetAllEmployeeData();
            Employee = employeeData;
        }

        public IActionResult OnPostViewDetailsBtn(string name)
        {
            var selectedDateString = Request.Form["selectedMonth"].ToString();
            if (SelectedMonthIsValid(selectedDateString) && SelectedNameIsValid(name))
            {
                var path = linkGenerator.GetUriByPage(this.HttpContext, "/Overview", values: new { date = selectedDateString, name = name });
                return Redirect(path);
            }

            return Page();
        }

        private bool SelectedMonthIsValid(string selectedMonth)
        {
            //TODO
            return true;
        }

        private bool SelectedNameIsValid(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
    }
}
