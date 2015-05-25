using Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Blocks.Frontend
{
  public static class MefApplicationExtensions
  {
    public static void InitMefApplication(this Application app)
    {
      app.Startup += (sender, args) =>
      {
        var appContainer = app.FindResource("ApplicationContainer") as ApplicationContainer;
        appContainer.SetApplication(app);
      };

      app.Exit += (sender, args) =>
      {
        var appContainer = app.FindResource("ApplicationContainer") as ApplicationContainer;
        appContainer.Dispose();

      };

      
    }

  }

  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  [Export(typeof(Application))]
  public partial class App : Application
  {

    public App()
    {
      this.InitMefApplication();
    }




  }


}
