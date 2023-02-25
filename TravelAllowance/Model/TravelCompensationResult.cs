namespace TravelAllowance.Model
{
   using NodaTime;

   public record TravelCompensationResult(string UserName, YearMonth Month, UserTravelAttributes TravelAttributes, int WorkedHoursNumber,
      double Compensation);
}
