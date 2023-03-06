namespace TravelCompensationUI.Pages
{
    using System.Globalization;
    using System.Text;

    using CsvHelper;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public IActionResult OnGetDownloadCsv()
        {
            FileContentResult result;
            using (var memStream = new MemoryStream())
            {
                var writer = new StreamWriter(memStream, Encoding.UTF8, 1024, true);
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture, true);
                csv.WriteRecords(new List<TravelCompensationResult>() { Compensation });
                result = new FileContentResult(memStream.GetBuffer(), "text/csv")
                {
                    FileDownloadName = $"TravelAllowanceOverview_{Name}_{Date}.csv"
                };
                csv.Dispose();
                writer.Dispose();
            }

            return result;
        }
    }
}
