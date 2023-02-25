namespace TravelAllowance
{
   using TravelAllowance.Model;

   public class TravelCompensationCalculator : ITravelCompensationCalculator
   {
      public double CalculateCompensationForUser(int distance, TravelCompensationRule rule, int workedDaysNumber)
      {
         if (rule.RuleExceptions.Any())
         {
            var exception = rule.RuleExceptions.First();
            if (distance > exception.MinKm && distance < exception.MaxKm)
            {
               return (double)(workedDaysNumber * distance * exception.Factor) * rule.BaseCompensationPerKm;
            }
         }

         return (double)(workedDaysNumber * distance) * rule.BaseCompensationPerKm;
      }
   }
}
