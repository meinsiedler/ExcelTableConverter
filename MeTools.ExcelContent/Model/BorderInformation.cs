using System;

namespace MeTools.ExcelContent.Model
{
  [Serializable]
  public class BorderInformation
  {
    public enum BorderStyleEnum
    {
      None,
      Solid,
      Dashed,
      Dotted,
      DoubleLineSolid
    }

    public enum ThicknessEnum
    {
      Hairline,
      Thin,
      Medium,
      Thick
    }

    public BorderStyleEnum BorderStyle { get; set; }

    public ThicknessEnum Thickness { get; set; }

    public override string ToString()
    {
      return string.Format("Style: {0}, Thickness: {1}", BorderStyle, Thickness);
    }

  }
}
