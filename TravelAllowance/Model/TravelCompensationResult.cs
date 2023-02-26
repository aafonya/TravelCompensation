namespace TravelAllowance.Model
{
   using NodaTime;

   public record TravelCompensationResult(string UserName, YearMonth Month, UserTravelAttributes TravelAttributes, int WorkedDaysNumber,
      double Compensation);

   public record TravelCompensationResultForCSV(string UserName, string Month, UserTravelAttributes TravelAttributes, int WorkedDaysNumber,
      double Compensation);
}
