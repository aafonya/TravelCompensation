namespace TravelAllowanceWebApp.Models
{
    public class WorkDay
    {
        public int ID { get; set; }

        public DateTime Day { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
