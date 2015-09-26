using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.JiraTableConverter.EmphTextStylers
{
  public class ItalicTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return string.Format("_{0}_", text);
    }
  }
}
