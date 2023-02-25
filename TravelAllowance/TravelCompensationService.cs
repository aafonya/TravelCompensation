namespace TravelAllowance
{
   using ExampleAPIClient.Client;

   using NodaTime;

   using TravelAllowance.Model;

   public class TravelCompensationService
   {
      public TravelCompensationService(IDBHandler dbHandler, IRestClient restClient, ITravelCompensationCalculator calculator)
      {
         DbHandler = dbHandler;
         RestClient = restClient;
         CompensationCalculator = calculator;
      }

      private IDBHandler DbHandler { get; }

      private IRestClient RestClient { get; }

      private ITravelCompensationCalculator CompensationCalculator { get; }

      public async Task<TravelCompensationResult> GetOverViewForUserOfMonth(string userName, YearMonth month)
      {
         var userTravelAttributes = await DbHandler.GetUserTravelAttributes(userName);
         var userWorkedHoursNumber = await DbHandler.GetUserWorkingDaysNumber(userName, month);

         var currentCompensationRules = await RestClient.GetTravelCompensationRules();

         var userCompensationRule = currentCompensationRules.First(r => r.Id == userTravelAttributes.TravelType);

         var compensation = CompensationCalculator.CalculateCompensationForUser(userTravelAttributes.TravelDistance, userCompensationRule, userWorkedHoursNumber);

         return new TravelCompensationResult(userName, month, userTravelAttributes, userWorkedHoursNumber, compensation);
      }
   }
}
