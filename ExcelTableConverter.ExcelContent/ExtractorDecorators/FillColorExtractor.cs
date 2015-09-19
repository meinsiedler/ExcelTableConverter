using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class FillColorExtractor : ExtractorDecorator
  {
    public FillColorExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);

      cell.FillColor = System.Drawing.ColorTranslator.FromOle(excelCell.OleFillColor);
      return cell;
    }
  }
}
