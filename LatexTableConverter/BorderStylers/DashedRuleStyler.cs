using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.BorderStylers
{
  public class DashedRuleStyler : HorizontalRuleStyler
  {

    private const int c_defaultDashWidth = 4;
    private const int c_defaultGapWidth = 4;

    public override string GetTopHorizontalRule(Row row)
    {
      return GetHorizontalRule(row, Cell.BorderPositionEnum.Top);
    }

    public override string GetBottomHorizontalRule(Row row)
    {
      return GetHorizontalRule(row, Cell.BorderPositionEnum.Bottom);
    }

    private string GetHorizontalRule(Row row, Cell.BorderPositionEnum borderPosition)
    {
      return GetRuleCommand(GetRuleRangesFromTo(row, borderPosition));
    }

    protected override string GetRuleCommand(Dictionary<string, BorderInformation.BorderStyleEnum> ranges)
    {
      string result = "";
      foreach (var range in ranges)
      {
        result += string.Format("\\cdashline{{{0}}}{1} ", range.Key, FineTuneDashWidths(GetDashWidth(), GetGapWidth()));
      }
      return result;
    }

    private string FineTuneDashWidths(int dashWidth, int gapWidth)
    {
      if(dashWidth != c_defaultDashWidth && gapWidth != c_defaultGapWidth)
        return string.Format("[{0}pt/{1}pt]", dashWidth, gapWidth);
      return string.Empty;
    }

    protected virtual int GetDashWidth()
    {
      return c_defaultDashWidth;
    }

    protected virtual int GetGapWidth()
    {
      return c_defaultGapWidth;
    }
  }
}
