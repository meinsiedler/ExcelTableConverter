﻿using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.LatexTableConverter.EmphTextStylers
{
  public class ItalicTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return string.Format("\\textit{{{0}}}", text);
    }
  }
}
