namespace TravelAllowance;

using NodaTime;
using TravelAllowance.Model;

public interface ITravelCompensationService
{
   Task<TravelCompensationResult> GetOverViewForUserOfMonth(string userName, YearMonth month);

   Task<List<EmployeeRecord>> GetAllEmployeeData();
}