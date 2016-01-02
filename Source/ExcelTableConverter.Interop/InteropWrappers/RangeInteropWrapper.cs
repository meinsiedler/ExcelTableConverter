using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.Interop.InteropConverter;
using Microsoft.Office.Interop.Excel;
using IBorder = ExcelTableConverter.ExcelContent.Model.IBorder;
using IFont = ExcelTableConverter.ExcelContent.Model.IFont;
using IRange = ExcelTableConverter.ExcelContent.Model.IRange;

namespace ExcelTableConverter.Interop.InteropWrappers
{
  public class RangeInteropWrapper : IRange
  {
    private readonly Range _interopRange;

    public RangeInteropWrapper(Range interopRange)
    {
      _interopRange = interopRange;
    }

    public IRange this[int rowIndex, int columnIndex]
    {
      get { return new RangeInteropWrapper(_interopRange[rowIndex, columnIndex]); }
    }

    public string Text
    {
      get { return _interopRange.Text; }
    }

    public IDictionary<Cell.BorderPositionEnum, IBorder> Borders
    {
      get { return new BordersInteropConverter().ConvertFromInterop(_interopRange.Borders); }
    }

    public Cell.HorizontalAlignmentEnum HorizontalAlignment
    {
      get
      {
        if (_interopRange.HorizontalAlignment == (int)XlHAlign.xlHAlignRight)
        {
          return Cell.HorizontalAlignmentEnum.Right;
        }
        if (_interopRange.HorizontalAlignment == (int)XlHAlign.xlHAlignCenter)
        {
          return Cell.HorizontalAlignmentEnum.Center;
        }
        if (_interopRange.HorizontalAlignment == (int)XlHAlign.xlHAlignGeneral)
        {
          return Cell.HorizontalAlignmentEnum.General;
        }
        return Cell.HorizontalAlignmentEnum.Left;
      }
    }

    public IFont Font
    {
      get { return new FontInteropWrapper(_interopRange.Font); }
    }

    public int OleFillColor
    {
      get { return (int)_interopRange.Interior.Color; }
    }
  }
}
