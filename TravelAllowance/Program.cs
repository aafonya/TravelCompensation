// See https://aka.ms/new-console-template for more information

using System.IO.Abstractions;

using ExampleAPIClient.Client;

using NodaTime;

using TravelAllowance;
using TravelAllowance.Model;

Console.WriteLine("Hello, World!");

string Uri = "https://api.staging.yeshugo.com/applicant/travel_types";

var dbHandler = new DBHandler();
var restClient = new RestClient(Uri);
var calculator = new TravelCompensationCalculator();
var fileSystem = new System.IO.Abstractions.FileSystem();
var csvGenerator = new CSVFileGenerator(fileSystem);
var nodaClock = SystemClock.Instance;

var service = new TravelCompensationService(dbHandler, restClient, calculator);
var overView = await service.GetOverViewForUserOfMonth("userName", new YearMonth(2023, 1));


csvGenerator.GenerateCompensationOverviewCSV(new List<TravelCompensationResult>(){ overView}, nodaClock, @"D:\\");