namespace TravelAllowance.Model
{
   using NodaTime;

   public record TravelCompensationResult(string UserName, YearMonth Month, TravelAttributesRecord TravelAttributes, int WorkedDaysNumber,
      double Compensation);

   public record TravelCompensationResultForCSV(string UserName, string Month, TravelAttributesRecord TravelAttributes, int WorkedDaysNumber,
      double Compensation);
}
