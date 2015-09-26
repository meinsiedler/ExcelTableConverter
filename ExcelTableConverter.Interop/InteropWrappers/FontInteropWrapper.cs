using Microsoft.Office.Interop.Excel;
using IFont = ExcelTableConverter.ExcelContent.Model.IFont;

namespace ExcelTableConverter.Interop.InteropWrappers
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
      get { return (int)_interopFont.Color; }
      set { _interopFont.Color = (double)value; }
    }
  }
}
