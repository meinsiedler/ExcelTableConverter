using System.Collections.Generic;
using ExcelTableConverter.ExcelContent.Model;
using Microsoft.Office.Interop.Excel;

namespace ExcelTableConverter.ExcelContent.ExtractorDecorators
{
  public class EmphasisExtractor : ExtractorDecorator
  {
    private readonly ExcelReader _excelReader;

    public EmphasisExtractor(ExcelReader excelReader) : base(excelReader)
    {
      _excelReader = excelReader;
    }

    public override Cell ExtractExcelCellProperty(Range excelCell)
    {
      Cell cell = _excelReader.ExtractExcelCellProperty(excelCell);
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
