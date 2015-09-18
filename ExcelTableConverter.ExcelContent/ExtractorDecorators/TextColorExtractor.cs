using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  class TextColorExtractor : ExtractorDecorator
  {
    public TextColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      cell.TextColor = System.Drawing.ColorTranslator.FromOle((int) excelCell.Font.Color);
      return cell;
    }
  }
}
