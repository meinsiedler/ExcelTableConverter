using ExcelTableConverter.TableConverter.EmphTextStylers;

namespace ExcelTableConverter.JiraTableConverter.EmphTextStylers
{
  public class BoldTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return string.Format("*{0}*", text);
    }
  }
}
