// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICSVFileGenerator.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2023
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TravelAllowance;

using NodaTime;

using TravelAllowance.Model;

public interface ICSVFileGenerator
{
   bool GenerateCompensationOverviewCSV(IEnumerable<TravelCompensationResult> overviews, IClock nodaClock, string targetDirectory);
}