using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class HorizontalAlignmentExtractor : ExtractorDecorator
  {
    public HorizontalAlignmentExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);
      cell.HorizontalAlignment = excelCell.HorizontalAlignment;
      return cell;
    }
  }
}
