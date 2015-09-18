using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class HorizontalAlignmentExtractor : ExtractorDecorator
  {
    public HorizontalAlignmentExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      if (excelCell.HorizontalAlignment == (int)XlHAlign.xlHAlignRight)
      {
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.Right;
      }
      else if (excelCell.HorizontalAlignment == (int)XlHAlign.xlHAlignCenter)
      {
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.Center;
      }
      else if (excelCell.HorizontalAlignment == (int) XlHAlign.xlHAlignGeneral)
      {
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.General;
      }
      else
      {
        cell.HorizontalAlignment = Cell.HorizontalAlignmentEnum.Left;
      }
      return cell;
    }
  }
}
