using Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;
using Blocks.Frontend.ViewModels;

namespace Blocks.Frontend
{
  [Export("MainViewModel")]
  public class MainViewModel : ViewModelBase
  {

    [Import]
    IApplicationService App { get; set; }

    public MainViewModel()
    {
      ViewName = "hello world";
      TheProperty = new MyProp();
    }

    public string ViewName { get { return Get<string>(); } set { Set(value); } }

    public void Exit()
    {
      App.ShowMessage("GAY","");
    }
    public void SetProperty()
    {
      TheProperty = new MyProp();
    }
    public object TheProperty
    {
      get
      {
        return Get<object>();
      }
      set
      {
        Set(value);
      }
    }



  }
}
