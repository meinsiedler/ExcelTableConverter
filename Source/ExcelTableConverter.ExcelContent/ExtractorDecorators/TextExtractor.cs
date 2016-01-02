using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class TextExtractor : ExtractorDecorator
  {
    public TextExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);
      cell.Text = excelCell.Text;
      return cell;
    }
  }
}
