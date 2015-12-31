using System.Collections.Generic;
using ExcelTableConverter.JiraTableConverter;
using ExcelTableConverter.LatexTableConverter;
using ExcelTableConverter.MarkdownTableConverter;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.AddIn
{
  public class NewOperatorConverterLoader : IConverterLoader
  {
    public IEnumerable<BaseTableConverter> GetConverters()
    {
      return new BaseTableConverter[]
      {
        new LatexConverter(),
        new JiraConverter(),
        new MarkdownConverter()
      };
    }
  }
}
