namespace TravelAllowance
{
   public record EmployeeRecord
   {
      public EmployeeRecord(string name, TravelAttributesRecord travelattr, List<DateTime> workDays)
      {
         Name = name;
         TravelAttribute = travelattr;
         WorkDays = workDays;
      }

      public string Name { get; }

      public TravelAttributesRecord TravelAttribute { get; set; }
      public List<DateTime> WorkDays { get; set; }
   }
}
