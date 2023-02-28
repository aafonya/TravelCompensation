
namespace TravelAllowance;

using NodaTime;

public interface IDBHandler
{
   Task<int> GetEmployeeWorkingDaysNumber(string userName, YearMonth month);

   Task<TravelAttributesRecord> GetEmployeeTravelAttributes(string userName);

   Task<List<EmployeeRecord>> GetAllEmployeeData();
}