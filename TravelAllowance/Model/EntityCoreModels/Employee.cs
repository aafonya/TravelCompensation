namespace TravelAllowanceWebApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public TravelAttributes TravelAttribute { get; set; }
        public List<WorkDay> WorkDays { get; set; }
   }
}
