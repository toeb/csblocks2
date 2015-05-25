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
  public class ApplicationContainer : CompositionContainer
  {
    public ApplicationContainer()
      : base(new ApplicationCatalog())
    {
  
    }
  
    public void SetApplication(Application app)
    {
      this.ComposeParts(app);
    }
  
    public object this[string service]
    {
      get
      {
        var export = this.GetExport<object>(service);
        return export.Value;
      }
    }
  }
}
