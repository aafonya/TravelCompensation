using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TravelCompensationUI.Pages
{
   using TravelAllowance;

   public class IndexModel : PageModel
   {
      private readonly ITravelCompensationService compensationService;
      public IndexModel(ITravelCompensationService compensationService)
      {
         this.compensationService = compensationService;
      }
      public IQueryable<EmployeeRecord> Employees { get; set; }

      public async void OnGet()
      {
         var employeeData =  await compensationService.GetAllEmployeeData();
         Employees = employeeData.AsQueryable();
      }

      public void OnPost()
      {
         var emailAddress = Request.Form["monthpicker"];
         // do something with emailAddress
      }
    }
}