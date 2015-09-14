using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace METools.LatexTableConverter.Justifiers
{
  class RightJustifier : Justifier
  {
    public override char GetAlignment()
    {
      return 'r';
    }
  }
}
