// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDBHandler.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2023
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TravelAllowance;

using NodaTime;

public interface IDBHandler
{
   Task<int> GetUserWorkingDaysNumber(string userName, YearMonth month);

   Task<UserTravelAttributes> GetUserTravelAttributes(string userName);
}