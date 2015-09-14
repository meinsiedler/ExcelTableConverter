using System.Drawing;

namespace ExcelTableConverter.LatexTableConverter.ColorStylers
{
  class TextColorStyler : ColorStyler
  {
    protected override string ColorizeCommand(Color color, string text)
    {
      return string.Format("\\textcolor[rgb]{{{0}}}{{{1}}}", GetDoubleRgbValues(color), text);
    }

    protected override Color ExcludeColor
    {
      get { return Color.Black; }
    }
  }
}
