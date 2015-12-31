using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.MarkdownTableConverter.CellFormatters;
using ExcelTableConverter.TableConverter;
using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.MarkdownTableConverter
{
  public class MarkdownConverter : BaseTableConverter
  {
    private ICellFormatter _cellFormatter;

    public MarkdownConverter()
    {
      _cellFormatter = new CellFormatter();
    }

    public override string ConverterName
    {
      get { return "Markdown"; }
    }

    public override string ToString()
    {
      return ConverterName;
    }

    public override string GetConvertedContent(Table excelTable)
    {
      ArgumentUtility.EnsureNotNull(excelTable, "excelTable");

      var str = new StringBuilder();
      var isFirstRow = true;
      foreach (var row in excelTable.Rows)
      {
        foreach (var cell in row.Columns)
        {
          str.Append(string.Format("{0} {1} ", GetColumnSeparator(), PrepareCellValue(cell)));
        }
        str.AppendLine(GetColumnSeparator());
        if (isFirstRow)
        {
          str.AppendLine(GetHeaderSeparator(row));
        }
        isFirstRow = false;
      }
      return str.ToString();
    }

    private string PrepareCellValue(Cell cell)
    {
      return _cellFormatter.Format(cell);
    }

    private string GetColumnSeparator()
    {
      return "|";
    }

    private string GetHeaderSeparator(Row row)
    {
      var str = new StringBuilder();
      var spacesReplacementLength = 2;
      foreach (var cell in row.Columns)
      {
        str.Append(string.Format("{0}{1}", GetColumnSeparator(), new string('-', cell.Text.Length + spacesReplacementLength)));
      }
      str.Append(GetColumnSeparator());
      return str.ToString();
    }

    public override string GetFileExtension()
    {
      return "md";
    }
  }
}
