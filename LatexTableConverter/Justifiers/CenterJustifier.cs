using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace METools.LatexTableConverter.Justifiers
{
  public class CenterJustifier : Justifier
  {
    public override char GetAlignment()
    {
      return 'c';
    }
  }
}
