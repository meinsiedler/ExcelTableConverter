using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class FillColorExtractor : ExtractorDecorator
  {
    private ExcelReader _excelReader;

    public FillColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);

      cell.FillColor = System.Drawing.ColorTranslator.FromOle((int)excelCell.Interior.Color);
      return cell;
    }
  }
}
