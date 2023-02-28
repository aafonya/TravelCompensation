namespace TravelAllowance;

using TravelAllowance.Model;

public interface ITravelCompensationCalculator
{
   double CalculateCompensationForUser(int distance, TravelCompensationRule rule, int workedDaysNumber);
}