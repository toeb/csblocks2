using Blocks.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Core.ViewModel
{

  public class ViewModelBase :PropertyChangingScope
  {
    private CommandProvider commandProvider;
    public CommandProvider Command { get { return commandProvider ?? (commandProvider = new CommandProvider(this)); } }
  }
}
