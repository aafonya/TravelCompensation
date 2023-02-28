namespace TravelAllowance.Model
{
   using System.Runtime.Serialization;

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
