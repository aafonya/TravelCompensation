using ExampleAPIClient.Client;
using Ninject;
using NodaTime;
using System.IO.Abstractions;
using TravelAllowance;

namespace TravelAllowanceOverview.IoC
{
   public static class IocContainer
   {
      public static IKernel Kernel { get; private set; } = new StandardKernel();

      public static void Setup()
      {
         Kernel.Bind<IRestClient>().To<RestClient>().WithConstructorArgument("https://api.staging.yeshugo.com/applicant/travel_types");
         Kernel.Bind<IDBHandler>().To<DBHandler>();
         Kernel.Bind<ITravelCompensationCalculator>().To<TravelCompensationCalculator>();
         Kernel.Bind<IFileSystem>().To<FileSystem>();
         Kernel.Bind<ICSVFileGenerator>().To<CSVFileGenerator>().WithConstructorArgument(Kernel.Get<IFileSystem>());
         Kernel.Bind<IClock>().ToConstant(SystemClock.Instance);
         Kernel.Bind<ITravelCompensationService>().To<TravelCompensationService>()
            .WithConstructorArgument(Kernel.Get<IDBHandler>())
            .WithConstructorArgument(Kernel.Get<IRestClient>())
            .WithConstructorArgument(Kernel.Get<ITravelCompensationCalculator>());
         BindViewModels();
      }

      private static void BindViewModels()
      {
         Kernel.Bind<MainWindowViewModel>().ToSelf().InSingletonScope().WithConstructorArgument(Kernel.Get<ITravelCompensationService>());
      }
   }
}