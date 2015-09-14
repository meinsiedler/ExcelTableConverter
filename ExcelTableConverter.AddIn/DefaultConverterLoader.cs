using ExcelTableConverter.JiraTableConverter;
using ExcelTableConverter.LatexTableConverter;

namespace MEExcelTools
{
  /// <summary>
  /// loads the Converters with new statement - not very clean solution,
  /// when adding a better solution, rewrite the ConverterProvider class to return
  /// another class
  /// </summary>
  public class DefaultConverterLoader : IConverterLoader
  {
    public void Load()
    {
      new LatexConverter();
      new JiraWikiConverter();
    }
  }
}
