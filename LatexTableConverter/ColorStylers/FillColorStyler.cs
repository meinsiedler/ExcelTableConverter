using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace METools.LatexTableConverter.ColorStylers
{
  class FillColorStyler : ColorStyler
  {
    protected override string ColorizeCommand(Color color, string text)
    {
      return string.Format("\\cellcolor[rgb]{{{0}}}{{{1}}}", GetDoubleRgbValues(color), text);
    }

    protected override Color ExcludeColor
    {
      get { return Color.White; }
    }
  }
}
