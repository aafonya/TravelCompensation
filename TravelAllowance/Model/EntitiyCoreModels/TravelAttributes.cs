namespace TravelAllowanceWebApp.Models
{
    public class TravelAttributes
    {
        public int ID { get; set; }
        public int TravelType { get; set; }
        public int DistanceInKm { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
   }
}
