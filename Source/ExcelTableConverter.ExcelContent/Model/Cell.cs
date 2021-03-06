﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace ExcelTableConverter.ExcelContent.Model
{
  [Serializable]
  public class Cell
  {
    public enum HorizontalAlignmentEnum
    {
      General,
      Left,
      Center,
      Right
    }

    public enum VerticalAlignmentEnum
    {
      Top,
      Center,
      Bottom
    }

    public enum BorderPositionEnum
    {
      Left,
      Top,
      Right,
      Bottom
    }

    public enum EmphasisEnum
    {
      None,
      Bold,
      Italic
    }

    public HorizontalAlignmentEnum HorizontalAlignment { get; set; }
    public VerticalAlignmentEnum VerticalAlignment { get; set; }
    public Dictionary<BorderPositionEnum, BorderInformation> Borders { get; set; }
    
    public string Text { get; set; }
    public List<EmphasisEnum> TextEmphasis { get; set; }
    public Color TextColor { get; set; }
    public Color FillColor { get; set; }

  }
}
