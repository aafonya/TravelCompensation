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
            new EmployeeRecord("Hein", new TravelAttributesRecord(3, 12),
            new List<DateTime>(){ new DateTime(2023, 01, 03),
            new DateTime(2023, 01, 04),
            new DateTime(2023, 01, 05),
            new DateTime(2023, 01, 06),
            new DateTime(2023, 01, 07),
            new DateTime(2023, 01, 08),
            new DateTime(2023, 01, 09),
            new DateTime(2023, 01, 10),
            new DateTime(2023, 01, 11),
            new DateTime(2023, 01, 12),
            new DateTime(2023, 01, 13),
            new DateTime(2023, 01, 14),
            new DateTime(2023, 01, 15),
            new DateTime(2023, 01, 16),
            new DateTime(2023, 01, 18)}),

            new EmployeeRecord("Florian", new TravelAttributesRecord(4, 15),
            new List<DateTime>(){ new DateTime(2023, 01, 03),
            new DateTime(2023, 01, 04),
            new DateTime(2023, 01, 05),
            new DateTime(2023, 01, 06),
            new DateTime(2023, 01, 07),
            new DateTime(2023, 01, 08),
            new DateTime(2023, 01, 09),
            new DateTime(2023, 01, 10),
            new DateTime(2023, 01, 11),
            new DateTime(2023, 01, 12),
            new DateTime(2023, 01, 13),
            new DateTime(2023, 01, 14),
            new DateTime(2023, 01, 15),
            new DateTime(2023, 01, 16),
            new DateTime(2023, 01, 17),
            new DateTime(2023, 01, 18)}),

            new EmployeeRecord("Wobbe", new TravelAttributesRecord(4, 20),
               new List<DateTime>(){ new DateTime(2023, 01, 03),
                  new DateTime(2023, 01, 04),
                  new DateTime(2023, 01, 05),
                  new DateTime(2023, 01, 06),
                  new DateTime(2023, 01, 07),
                  new DateTime(2023, 01, 08),
                  new DateTime(2023, 01, 09),
                  new DateTime(2023, 01, 10),
                  new DateTime(2023, 01, 11),
                  new DateTime(2023, 01, 12),
                  new DateTime(2023, 01, 13),
                  new DateTime(2023, 01, 14),
                  new DateTime(2023, 01, 15),
                  new DateTime(2023, 01, 16),
                  new DateTime(2023, 01, 18)}),

            new EmployeeRecord("Dolf", new TravelAttributesRecord(3, 15),
               new List<DateTime>(){ new DateTime(2023, 01, 03),
                  new DateTime(2023, 01, 04),
                  new DateTime(2023, 01, 05),
                  new DateTime(2023, 01, 06),
                  new DateTime(2023, 01, 07),
                  new DateTime(2023, 01, 08),
                  new DateTime(2023, 01, 09),
                  new DateTime(2023, 01, 10),
                  new DateTime(2023, 01, 11),
                  new DateTime(2023, 01, 12),
                  new DateTime(2023, 01, 13),
                  new DateTime(2023, 01, 14),
                  new DateTime(2023, 01, 15),
                  new DateTime(2023, 01, 16),
                  new DateTime(2023, 01, 17),
                  new DateTime(2023, 01, 18)}),

         });
         return result.Task.Result;
      }
   }
}
