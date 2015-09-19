using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;
using IRange = ExcelTableConverter.ExcelContent.Model.IRange;

namespace ExcelTableConverter.Interop.InteropWrappers
{
  public class WorksheetInteropWrapper : IWorksheet
  {
    private readonly Worksheet _interopWorksheet;

    public WorksheetInteropWrapper(Worksheet interopWorksheet)
    {
      _interopWorksheet = interopWorksheet;
    }

    public string Name
    {
      get { return _interopWorksheet.Name; }
    }

    public IRange Cells
    {
      get { return new RangeInteropWrapper(_interopWorksheet.Cells); }
    }
  }
}
