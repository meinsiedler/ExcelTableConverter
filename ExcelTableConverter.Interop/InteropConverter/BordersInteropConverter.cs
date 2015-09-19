using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.Interop.InteropWrappers;
using Microsoft.Office.Interop.Excel;
using IBorder = ExcelTableConverter.ExcelContent.Model.IBorder;

namespace ExcelTableConverter.Interop.InteropConverter
{
  public class BordersInteropConverter : IInteropConverter<Borders, IDictionary<Cell.BorderPositionEnum, IBorder>>
  {
    public IDictionary<Cell.BorderPositionEnum, IBorder> ConvertFromInterop(Borders obj)
    {
      return new Dictionary<Cell.BorderPositionEnum, IBorder>
      {
        {Cell.BorderPositionEnum.Left, new BorderInteropWrapper(obj[XlBordersIndex.xlEdgeLeft])},
        {Cell.BorderPositionEnum.Top, new BorderInteropWrapper(obj[XlBordersIndex.xlEdgeTop])},
        {Cell.BorderPositionEnum.Right, new BorderInteropWrapper(obj[XlBordersIndex.xlEdgeRight])},
        {Cell.BorderPositionEnum.Bottom, new BorderInteropWrapper(obj[XlBordersIndex.xlEdgeBottom])}
      };
    }
  }
}
