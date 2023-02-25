// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITravelCompensationCalculator.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2023
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TravelAllowance;

using TravelAllowance.Model;

public interface ITravelCompensationCalculator
{
   double CalculateCompensationForUser(int distance, TravelCompensationRule rule, int workedDaysNumber);
}