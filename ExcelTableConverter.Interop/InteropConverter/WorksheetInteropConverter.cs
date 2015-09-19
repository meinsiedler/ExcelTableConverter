using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.Interop.InteropWrappers;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.Interop.InteropConverter
{
  public class WorksheetInteropConverter : IInteropConverter<Worksheet, IWorksheet>
  {
    public IWorksheet ConvertFromInterop(Worksheet obj)
    {
      return new WorksheetInteropWrapper(obj);
    }
  }
}
