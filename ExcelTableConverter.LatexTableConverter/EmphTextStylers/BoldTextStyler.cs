namespace ExcelTableConverter.LatexTableConverter.EmphTextStylers
{
  public class BoldTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return string.Format("\\textbf{{{0}}}", text);
    }
  }
}
