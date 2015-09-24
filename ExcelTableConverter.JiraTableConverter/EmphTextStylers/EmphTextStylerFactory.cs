using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.JiraTableConverter.EmphTextStylers
{
  public static class EmphTextStylerFactory
  {
    public static IList<EmphTextStyler> GetTextStylers(Cell cell)
    {
      if (cell.TextEmphasis == null || !cell.TextEmphasis.Any())
      {
        return Enumerable.Empty<EmphTextStyler>().ToList();
      }

      var textStylers = new List<EmphTextStyler>();
      foreach (var emphasisEnum in cell.TextEmphasis)
      {
        if (emphasisEnum == Cell.EmphasisEnum.Bold)
          textStylers.Add(new BoldTextStyler());
        if (emphasisEnum == Cell.EmphasisEnum.Italic)
          textStylers.Add(new ItalicTextStyler());
      }
      return textStylers;
    }

    public static string GetCombinedTextStyle(Cell cell, string value = null)
    {
      return new CombinedTextStyler(GetTextStylers(cell)).Style(value ?? cell.Text);
    }
  }
}
