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
  [Export(typeof(IApplicationService))]
  public class ApplicationService : IApplicationService
  {
  
    [ImportingConstructor]
    public ApplicationService([Import]Application app)
    {
      this.Application = app;
    }

    public void CreateWindow(string viewName)
    {

    }
  
    public void ShowMessage(string title, string content)
    {
      MessageBox.Show(content, title);
    }
  
    public void RequestExit()
    {
      Application.Shutdown();
    }
  
    public Application Application { get; set; }
  }
}
