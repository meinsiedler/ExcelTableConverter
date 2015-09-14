using MeTools.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace MeTools.ExcelContent.ExtractorDecorators
{
  public class TextExtractor : ExtractorDecorator
  {
    private readonly ExcelReader _excelReader;

    public TextExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }
    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);
      cell.Text = excelCell.Text;
      return cell;
    }
  }
}
