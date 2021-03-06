﻿using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.TableConverter.EmphTextStylers
{
  public abstract class EmphTextStylerFactory
  {
    public virtual IList<EmphTextStyler> GetTextStylers(Cell cell)
    {
      if (cell.TextEmphasis == null || !cell.TextEmphasis.Any())
      {
        return Enumerable.Empty<EmphTextStyler>().ToList();
      }

      var textStylers = new List<EmphTextStyler>();
      foreach (var emphasisEnum in cell.TextEmphasis)
      {
        if (emphasisEnum == Cell.EmphasisEnum.Bold)
          textStylers.Add(GetBoldTextStyler());
        if (emphasisEnum == Cell.EmphasisEnum.Italic)
          textStylers.Add(GetItalicTextStyler());
      }
      return textStylers;
    }

    public string GetCombinedTextStyle(Cell cell, string value = null)
    {
      return new CombinedTextStyler(GetTextStylers(cell)).Style(value ?? cell.Text);
    }

    protected abstract EmphTextStyler GetBoldTextStyler();
    protected abstract EmphTextStyler GetItalicTextStyler();
  }
}
