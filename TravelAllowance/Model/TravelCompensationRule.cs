namespace TravelAllowance.Model
{
   using System.Runtime.Serialization;

   using System.Text.Json.Serialization;

   //public record class TravelCompensationRule(
   //   [property: JsonPropertyName("id")] int Id,
   //   [property: JsonPropertyName("name")] string Name,
   //   [property: JsonPropertyName("base_compensation_per_km")] double BaseCompensationPerKm,
   //   [property: JsonPropertyName("exceptions")] List<TravelCompensationRuleException> RuleExceptions
   //   )
   //{
   //}

   //public record class TravelCompensationRuleException(
   //   [property: JsonPropertyName("min_km")] int MinKm,
   //   [property: JsonPropertyName("max_km")] int MaxKm,
   //   [property: JsonPropertyName("factor")] int Factor)
   //{
   //}

   [DataContract]
   public class TravelCompensationRule
   {
      [DataMember(Name = "id")]
      public int Id { get; set; }

      [DataMember(Name = "name")]
      public string Name { get; set; }

      [DataMember(Name = "base_compensation_per_km")]
      public double BaseCompensationPerKm { get; set; }

      [DataMember(Name = "exceptions")]
      public List<TravelCompensationRuleException> RuleExceptions { get; set; }
   }

   [DataContract]
   public class TravelCompensationRuleException
   {
      [DataMember(Name = "min_km")]
      public int MinKm { get; set; }

      [DataMember(Name = "max_km")]
      public int MaxKm { get; set; }

      [DataMember(Name = "factor")]
      public int Factor { get; set; }

   }
}
