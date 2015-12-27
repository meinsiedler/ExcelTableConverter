using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.TableConverter;

namespace ExcelTableConverter.MarkdownTableConverter
{
  public class MarkdownConverter : BaseTableConverter
  {
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
      return "Not implemented yet!";
    }

    public override string GetFileExtension()
    {
      return "md";
    }
  }
}
