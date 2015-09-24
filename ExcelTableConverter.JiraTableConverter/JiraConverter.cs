using System.Text;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.JiraTableConverter.CellFormaters;
using ExcelTableConverter.TableConverter;
using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.JiraTableConverter
{
  public class JiraConverter : BaseTableConverter
  {
    private ICellFormatter _cellFormatter;

    public JiraConverter()
    {
      AddConverter(ConverterName(), this);
      _cellFormatter = new CellFormatter();
    }

    private string ConverterName()
    {
      return "Atlassian Jira";
    }

    public override string ToString()
    {
      return ConverterName();
    }

    public override string GetConvertedContent(Table excelTable)
    {
      ArgumentUtility.EnsureNotNull(excelTable, "excelTable");

      StringBuilder str = new StringBuilder();
      foreach (var row in excelTable.Rows)
      {
        foreach (var cell in row.Columns)
        {
          str.Append(string.Format("| {0} ", PrepareCellValue(cell)));
        }
        str.AppendLine("|");
      }
      return str.ToString();
    }

    private string PrepareCellValue(Cell cell)
    {
      return _cellFormatter.Format(cell);
    }

    public override string GetFileExtension()
    {
      return "txt";
    }
  }
}
