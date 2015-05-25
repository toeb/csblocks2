using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Blocks.Frontend.ViewModels
{
  [Serializable]
  public class MyProp
  {
    public MyProp()
    {
      Sub = new MySubProp();
    }
    [Category("TestCat")]
    [DisplayName("Just A Value")]
    public bool Test { get; set; }

    [ExpandableObject]
    public MySubProp Sub { get; set; }
  }


  [Serializable]
  public class MySubProp
  {
    [DisplayName("nanaa")]
    [Description("nmuha")]
    public string Lol { get; set; }
  }
}
