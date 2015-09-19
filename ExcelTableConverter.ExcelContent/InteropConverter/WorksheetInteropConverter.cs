using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.ExcelContent.Model.InteropWrappers;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.InteropConverter
{
  public class WorksheetInteropConverter : IInteropConverter<Worksheet, IWorksheet>
  {
    public IWorksheet ConvertFromInterop(Worksheet obj)
    {
      return new WorksheetInteropWrapper(obj);
    }
  }
}
