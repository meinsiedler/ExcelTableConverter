using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.MarkdownTableConverter.EmphTextStylers;


namespace ExcelTableConverter.MarkdownTableConverter.CellFormatters
{
  public class CellFormatter : ICellFormatter
  {
    public string Format(Cell cell)
    {
      var formattedCellValue = cell.Text;
      formattedCellValue = EmphasiseCellValue(cell, formattedCellValue);

      return formattedCellValue;
    }

    private string EmphasiseCellValue(Cell cell, string value)
    {
      return new EmphTextStylerFactory().GetCombinedTextStyle(cell, value);
    } 
  }
}
