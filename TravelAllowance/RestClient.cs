namespace ExampleAPIClient.Client
{
   using System.Net.Http.Headers;
   using System.Text.Json;

   using Newtonsoft.Json;

   using TravelAllowance.Model;

   public class RestClient : IRestClient
   {
      //TODO get this from config file
      private string Uri = "https://api.staging.yeshugo.com/applicant/travel_types";

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

         var ssssss = JsonConvert.DeserializeObject<List<TravelCompensationRule>>(json);
         //var repositories =
         //   await JsonSerializer.DeserializeAsync<List<TravelCompensationRule>>(stream);
         return ssssss ?? new();
      }
}
}