namespace TravelAllowance
{
   public record EmployeeRecord
   {
      public EmployeeRecord(string name, TravelAttributesRecord travelattr)
      {
         Name = name;
         TravelAttribute = travelattr;
      }

      public string Name { get; }

      public TravelAttributesRecord TravelAttribute { get; set; }
   }
}
