namespace TravelAllowance
{
   using NodaTime;

   public class DBHandler : IDBHandler
   {
      public async Task<int> GetUserWorkingDaysNumber(string userName, YearMonth month)
      {
         //TODO
         var result = new TaskCompletionSource<int>();
         result.SetResult(20);
         return result.Task.Result;
      }

      public async Task<UserTravelAttributes> GetUserTravelAttributes(string userName)
      {
         //TODO
         var result = new TaskCompletionSource<UserTravelAttributes>();
         result.SetResult(new UserTravelAttributes(2, 12));
         return result.Task.Result;
      }
   }
}
