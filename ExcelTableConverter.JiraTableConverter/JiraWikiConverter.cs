using System.Text;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.JiraTableConverter
{
  public class JiraWikiConverter : BaseTableConverter
  {
    public JiraWikiConverter()
    {
      AddConverter(ConverterName(), this);
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
      StringBuilder str = new StringBuilder();
      foreach (Row row in excelTable.Rows)
      {
        foreach (var cell in row.Columns)
        {
          str.Append(string.Format("| {0} ", cell.Text));
        }
        str.AppendLine("|");
      }
      return str.ToString();
    }

    public override string GetFileExtension()
    {
      return "txt";
    }
  }
}
