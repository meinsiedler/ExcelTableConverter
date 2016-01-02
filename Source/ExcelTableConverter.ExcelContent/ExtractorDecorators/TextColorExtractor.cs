using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class TextColorExtractor : ExtractorDecorator
  {
    public TextColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      cell.TextColor = System.Drawing.ColorTranslator.FromOle(excelCell.Font.OleColor);
      return cell;
    }
  }
}
