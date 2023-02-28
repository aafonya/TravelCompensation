﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TravelAllowanceOverview.IoC;

namespace TravelAllowanceOverview
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {
      protected override void OnStartup(StartupEventArgs e)
      {
         base.OnStartup(e);

         IocContainer.Setup();

         Current.MainWindow = new MainWindow();
         Current.MainWindow.Show();
      }
   }
}
