namespace TravelAllowance
{
   using CsvHelper;
   using System.Globalization;
   using System.IO.Abstractions;

   using NodaTime;

   using TravelAllowance.Model;

   public class CSVFileGenerator : ICSVFileGenerator
   {
      private IFileSystem fileSystem;
      public CSVFileGenerator(IFileSystem fileSystem)
      {
         this.fileSystem = fileSystem;
      }
      public bool GenerateCompensationOverviewCSV(IEnumerable<TravelCompensationResult> overviews, IClock nodaClock, string targetDirectory)
      {
         if (!ValidateTargetDirectory(targetDirectory))
         {
            return false;
         }

         var fileName = "TravelCompensationOverView_" + overviews.First().Month.ToString() + "_Calculated_" + nodaClock.GetCurrentInstant().ToDateTimeUtc().ToFileTimeUtc() + ".csv";
         using (var writer = new StreamWriter(Path.Combine(targetDirectory, fileName)))
         using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
         {
            csv.WriteRecords(overviews);
         }

         return true;
      }

      private bool ValidateTargetDirectory(string targetDirectory)
      {
         var directoryInfoWrapper = new DirectoryInfoWrapper(fileSystem, new DirectoryInfo(targetDirectory));
         return directoryInfoWrapper.Exists;
      }
   }
}
