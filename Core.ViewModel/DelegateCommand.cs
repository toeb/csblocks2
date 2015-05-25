using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;

namespace Core.ViewModel
{
  public class DelegateCommand : ICommand
  {
    public static DelegateCommand Reflect(object source, string commandName)
    {
      if (source == null) return null;
      var type = source.GetType();
      var method = type.GetMethod(commandName);

  
      if (method == null) return null;
  
  
      var result = new DelegateCommand();
      result.Action = param => method.Invoke(source, param == null ? new object[0] : new[] { param });


      return result;
    }

    public Func<object, bool> Can { get; set; }
    private DelegateCommand() { }
    public bool CanExecute(object parameter)
    {
      if (Can == null) return true;
      return Can(parameter);
    }
  
    public event EventHandler CanExecuteChanged;
  
    public void Execute(object parameter)
    {
      Action(parameter);
    }
  
    public Action<object> Action { get; set; }
  }
}
