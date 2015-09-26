using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent
{
  public class ExcelExtractor : ExcelReader
  {
    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      return new Cell();
    }
  }
}
