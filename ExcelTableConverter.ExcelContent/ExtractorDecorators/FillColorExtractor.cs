using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class FillColorExtractor : ExtractorDecorator
  {
    public FillColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      cell.FillColor = System.Drawing.ColorTranslator.FromOle((int)excelCell.Interior.Color);
      return cell;
    }
  }
}
