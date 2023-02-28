using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TravelAllowance;

namespace TravelAllowanceOverview
{
   using TravelAllowance.Model;

   public class MainWindowViewModel
   {
      ITravelCompensationService travelCompensationService;
      public MainWindowViewModel(ITravelCompensationService compensationService)
      {
         if(compensationService == null)
         {
            throw new ArgumentNullException($"{nameof(ITravelCompensationService)} not instanciated");
         }

         travelCompensationService = compensationService;
         Employees = new ObservableCollection<EmployeeViewModel>();
      }

      public ObservableCollection<EmployeeViewModel> Employees { get; set; }

      public async Task LoadEmployeeList()
      {
         Employees.Clear();
         var allEmployeeData = await travelCompensationService.GetAllEmployeeData();

         foreach (var employee in allEmployeeData)
         {
            //Calculate an average work days per month value
            var avergaeWorkDaysPerMonth = employee.WorkDays.GroupBy(d => d.Month).Select(g => g.Count()).Average();
            var employeeVm = new EmployeeViewModel(employee.Name,
               TravelTypeIdToStringMapper.TryMapTravelTypeIdToString(employee.TravelAttribute.TravelType) ?? throw new ArgumentException("Wrong travel type read from db"),
               employee.TravelAttribute.TravelDistance,
               avergaeWorkDaysPerMonth);

            Employees.Add(employeeVm);
         }
      }
   }
}
