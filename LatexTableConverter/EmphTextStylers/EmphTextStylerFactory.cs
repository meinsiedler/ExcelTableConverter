using System.Collections.Generic;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.EmphTextStylers
{
  public static class EmphTextStylerFactory
  {
    public static List<EmphTextStyler> GetTextStylers(Cell cell)
    {
      var textStylers = new List<EmphTextStyler>();
      foreach (var emphasisEnum in cell.TextEmphasis)
      {
        if (emphasisEnum == Cell.EmphasisEnum.Bold)
          textStylers.Add(new BoldTextStyler());
        if (emphasisEnum == Cell.EmphasisEnum.Italic)
          textStylers.Add(new ItalicTextStyler());
        if (emphasisEnum == Cell.EmphasisEnum.None)
          textStylers.Add(new NoEmphTextStyler());

      }
      return textStylers;
    }
  }
}
