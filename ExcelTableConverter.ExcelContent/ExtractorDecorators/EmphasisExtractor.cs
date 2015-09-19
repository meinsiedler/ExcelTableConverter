using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class EmphasisExtractor : ExtractorDecorator
  {
    public EmphasisExtractor(ExcelReader excelReader) : base(excelReader)
    {
    }

    public override Cell ExtractExcelCellProperty(IRange excelCell)
    {
      Cell cell = ExcelReader.ExtractExcelCellProperty(excelCell);
      cell.TextEmphasis = new List<Cell.EmphasisEnum>();

      if (excelCell.Font.Italic)
      {
        cell.TextEmphasis.Add(Cell.EmphasisEnum.Italic);
      }
      if (excelCell.Font.Bold)
      {
        cell.TextEmphasis.Add(Cell.EmphasisEnum.Bold);
      }
      if (cell.TextEmphasis.Count == 0)
      {
        cell.TextEmphasis.Add(Cell.EmphasisEnum.None);
      }
      return cell;
    }
  }
}
