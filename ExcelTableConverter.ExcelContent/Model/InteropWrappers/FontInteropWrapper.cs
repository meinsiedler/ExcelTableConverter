using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.Model.InteropWrappers
{
  public class FontInteropWrapper : IFont
  {
    private readonly Font _interopFont;

    public FontInteropWrapper(Font interopFont)
    {
      _interopFont = interopFont;
    }

    public bool Bold
    {
      get { return _interopFont.Bold; }
      set { _interopFont.Bold = value; }
    }

    public bool Italic
    {
      get { return _interopFont.Italic; }
      set { _interopFont.Italic = value; }
    }

    public int OleColor
    {
      get { return _interopFont.Color; }
      set { _interopFont.Color = value; }
    }
  }
}
