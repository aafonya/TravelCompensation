namespace TravelAllowance
{
   public record UserTravelAttributes
   {
      private int travelDistance;

      public UserTravelAttributes(int travelType, int travelDistance)
      {
         TravelType = travelType;
         TravelDistance = travelDistance <= Constants.MaxCommuteDistanceInKm
            ? travelDistance
            : throw new ArgumentException($"Trave distance can not be higher than the maximum allowed value {Constants.MaxCommuteDistanceInKm}");
      }

      public int TravelType { get; }

      public int TravelDistance
      {
         get => travelDistance;
         init
         {
            if (value <= Constants.MaxCommuteDistanceInKm)
            {
               new ArgumentException($"Trave distance can not be higher than the maximum allowed value {Constants.MaxCommuteDistanceInKm}");
            }

            travelDistance = value;
         }
      }
   }
}
