using TravelAllowanceOverview.WPFBaseClasses;

namespace TravelAllowanceOverview
{
   public class EmployeeViewModel : ObservableObject
   {
      public EmployeeViewModel(string name, string travelType, int distance, double workdaysPerWeek)
      {
         Name = name;
         TravelType = travelType;
         Distance = distance;
         WorkDaysPerWeek = workdaysPerWeek;  
      }
      private string name;
      public string Name
      {
         get { return name; }
         set
         {
            if (name != value)
            {
               name = value;
               NotifyPropertyChanged();
            }
         }
      }

      private string travelType;
      public string TravelType
      {
         get { return travelType; }
         set
         {
            if (travelType != value)
            {
               travelType = value;
               NotifyPropertyChanged();
            }
         }
      }

      private int distance;
      public int Distance
      {
         get { return distance; }
         set
         {
            if (distance != value)
            {
               distance = value;
               NotifyPropertyChanged();
            }
         }
      }

      private double workDaysPerWeek;
      public double WorkDaysPerWeek
      {
         get { return workDaysPerWeek; }
         set
         {
            if (workDaysPerWeek != value)
            {
               workDaysPerWeek = value;
               NotifyPropertyChanged();
            }
         }
      }
   }
}
