using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MeTools.ExcelContent.Model
{
  public class TextStyle
  {
    public enum EmphasisEnum
    {
      Bold,
      Italic,
      Unterline
    }

    public EmphasisEnum Emphasis { get; set; }

    public Color Color { get; set; }

  }
}
