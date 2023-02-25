// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRestClient.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2023
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ExampleAPIClient.Client;

using TravelAllowance.Model;

public interface IRestClient
{
   Task<List<TravelCompensationRule>> GetTravelCompensationRules();
}