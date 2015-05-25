using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Core.ViewModel
{
  public class CommandProvider
  {
    private IDictionary<string, ICommand> commands;
    public CommandProvider(object source)
    {
      commands = new Dictionary<string, ICommand>();
      this.Source = source;
    }
    public ICommand this[string commandName]
    {
      get
      {
        ICommand cmd;
        var success = commands.TryGetValue(commandName,out cmd);
        if (success && cmd != null) return cmd;
        cmd = DelegateCommand.Reflect(Source, commandName);
        commands[commandName] = cmd;
        return cmd;
      }
    }
  
    public object Source { get; set; }
  }
}
