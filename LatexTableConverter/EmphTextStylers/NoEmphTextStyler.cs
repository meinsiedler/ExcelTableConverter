namespace METools.LatexTableConverter.EmphTextStylers
{
  public class NoEmphTextStyler : EmphTextStyler
  {
    public override string Style(string text)
    {
      return text;
    }
  }
}
