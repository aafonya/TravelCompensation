using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TravelAllowance;
using TravelAllowanceWebApp.Models;

namespace TravelCompensationUI.Pages.NewFolder
{
    public class IndexModel : PageModel
    {
        private readonly ITravelCompensationService compensationService;

        public IndexModel(ITravelCompensationService compensationService)
        {
            this.compensationService = compensationService;
        }

        public List<EmployeeRecord> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            //if (_context.Employee != null)
            //{
            //    Employee = await _context.Employee.ToListAsync();
            //}
            var employeeData = await compensationService.GetAllEmployeeData();
            if (employeeData != null)
            {
                Employee = employeeData;
            }
            
        }
    }
}
