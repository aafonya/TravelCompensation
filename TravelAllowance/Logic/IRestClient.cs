
namespace ExampleAPIClient.Client;

using TravelAllowance.Model;

public interface IRestClient
{
   Task<List<TravelCompensationRule>> GetTravelCompensationRules();
}