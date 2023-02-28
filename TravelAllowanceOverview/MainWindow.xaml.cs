using Ninject;
using System.Windows;
using TravelAllowanceOverview.IoC;

namespace TravelAllowanceOverview
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         DataContext = IocContainer.Kernel.Get<MainWindowViewModel>();
      }

      public override void EndInit()
      {
         base.EndInit();
      }

      private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
      {
         (DataContext as MainWindowViewModel)?.LoadEmployeeList();
      }
   }
}
