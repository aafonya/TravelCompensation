namespace TravelAllowance
{
   using NodaTime;

   public class DBHandler : IDBHandler
   {
      public async Task<int> GetEmployeeWorkingDaysNumber(string userName, YearMonth month)
      {
         //TODO
         var result = new TaskCompletionSource<int>();
         result.SetResult(20);
         return result.Task.Result;
      }

      public async Task<TravelAttributesRecord> GetEmployeeTravelAttributes(string userName)
      {
         //TODO
         var result = new TaskCompletionSource<TravelAttributesRecord>();
         result.SetResult(new TravelAttributesRecord(2, 12));
         return result.Task.Result;
      }

      public async Task<List<EmployeeRecord>> GetAllEmployeeData()
      {
         var result = new TaskCompletionSource<List<EmployeeRecord>>();
         result.SetResult(new List<EmployeeRecord>()
         {
            new EmployeeRecord("Hein", new TravelAttributesRecord(3, 12)),

            new EmployeeRecord("Florian", new TravelAttributesRecord(4, 15)),

            new EmployeeRecord("Wobbe", new TravelAttributesRecord(4, 20)),

            new EmployeeRecord("Dolf", new TravelAttributesRecord(3, 15)
               ),

         });
         return result.Task.Result;
      }
   }
}
