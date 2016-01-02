using System.Text;
using System.Windows.Forms;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.JiraTableConverter.CellFormaters;
using ExcelTableConverter.TableConverter;
using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.JiraTableConverter
{
  public class JiraConverter : BaseTableConverter
  {
    private readonly IExtendedJiraFeatureModel _extendedFeatures;
    private readonly ICellFormatter _cellFormatter;

    public JiraConverter() : this(new ExtendedJiraFeatureModel())
    {
    }

    internal JiraConverter(IExtendedJiraFeatureModel extendedFeatures)
    {
      _extendedFeatures = extendedFeatures;
      _cellFormatter = new CellFormatter();
    }

    public override string ConverterName
    {
      get { return "Atlassian Jira"; }
    }

    public override string ToString()
    {
      return ConverterName;
    }

    public override string GetConvertedContent(Table excelTable)
    {
      ArgumentUtility.EnsureNotNull(excelTable, "excelTable");

      StringBuilder str = new StringBuilder();
      var isFirstRow = true;
      foreach (var row in excelTable.Rows)
      {
        foreach (var cell in row.Columns)
        {
          str.Append(string.Format("{0} {1} ", GetColumnSeparator(isFirstRow), PrepareCellValue(cell)));
        }
        str.AppendLine(GetColumnSeparator(isFirstRow));
        isFirstRow = false;
      }
      return str.ToString();
    }

    private string PrepareCellValue(Cell cell)
    {
      return _cellFormatter.Format(cell);
    }

    private string GetColumnSeparator(bool isFirstRow)
    {
      return _extendedFeatures.FirstRowIsHeader && isFirstRow ? "||" : "|";
    }

    public override string GetFileExtension()
    {
      return "txt";
    }

    public override UserControl ExtendedFeaturesUserControl
    {
      get { return _extendedFeatures.BoundExtendedFeaturesUserControl; }
    }
  }
}
