namespace TravelAllowance;

using NodaTime;

using TravelAllowance.Model;

public interface ICSVFileGenerator
{
   bool GenerateCompensationOverviewCSV(IEnumerable<TravelCompensationResult> overviews, IClock nodaClock, string targetDirectory);
}