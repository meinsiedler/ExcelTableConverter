using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent
{
  public class ExcelExtractor : ExcelReader
  {
    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      return new Cell();
    }
  }
}
