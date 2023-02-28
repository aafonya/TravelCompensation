using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAllowance.Model
{
   public static class TravelTypeIdToStringMapper
   {
      public static string? TryMapTravelTypeIdToString(int travelType)
      {
         switch (travelType)
         {
            case 1:
               return "Train";
            case 2:
               return "Car";
            case 3:
               return "Bike";
            case 4:
               return "Bus";
            default:
               return null;
         }
      }
   }
}
