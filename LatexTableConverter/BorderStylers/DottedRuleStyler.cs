namespace ExcelTableConverter.LatexTableConverter.BorderStylers
{
  public class DottedRuleStyler : DashedRuleStyler
  {
    protected override int GetDashWidth()
    {
      return 1;
    }

    protected override int GetGapWidth()
    {
      return 1;
    }
  }
}
