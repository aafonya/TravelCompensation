namespace ExampleAPIClient.Client
{
   using Newtonsoft.Json;

   using TravelAllowance.Model;

   public class RestClient : IRestClient
   {
      //TODO get this from config file
      private string Uri;

      public RestClient(string uri)
      {
         Uri = uri;
      }

      public async Task<List<TravelCompensationRule>> GetTravelCompensationRules()
      {
         using HttpClient client = new();
         return await ProcessTravelCompensationRulesAsync(client);
      }
      

      async Task<List<TravelCompensationRule>> ProcessTravelCompensationRulesAsync(HttpClient client)
      {
         //TODO cancellation token source in case user exits application?
          var json =  await client.GetStringAsync(Uri);
         var rules = JsonConvert.DeserializeObject<List<TravelCompensationRule>>(json);
         return rules ?? new();
      }
}
}