using ExcelTableConverter.ExcelContent.Model.InteropWrappers;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.InteropConverter
{
  public class RangeInteropConverter : IInteropConverter<Range, Model.IRange>
  {
    public Model.IRange ConvertFromInterop(Range obj)
    {
      return new RangeInteropWrapper(obj);
    }
  }
}
