using Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Reflection;

namespace Blocks.Frontend
{
  public interface IApplicationService
  {
    void RequestExit();
    void ShowMessage(string title, string content);
    
  }
}
