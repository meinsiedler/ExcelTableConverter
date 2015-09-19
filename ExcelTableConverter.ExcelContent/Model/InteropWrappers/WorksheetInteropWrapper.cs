using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.Model.InteropWrappers
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
