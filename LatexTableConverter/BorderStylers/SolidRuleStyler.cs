using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeTools.ExcelContent.Model;

namespace METools.LatexTableConverter.BorderStylers
{
  public class SolidRuleStyler : HorizontalRuleStyler
  {
    private int _columns;

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
      _columns = row.Columns.Count;
      return GetRuleCommand(GetRuleRangesFromTo(row, borderPosition));
    }

    protected override string GetRuleCommand(Dictionary<string, BorderInformation.BorderStyleEnum> ranges)
    {
      string hlineString = BuildHhlineString(ranges);

      var noneSym = GetHhlineSymbol(BorderInformation.BorderStyleEnum.None);
      bool notEmpty = hlineString.Any(sym => sym != noneSym);

      return notEmpty ? string.Format("\\hhline{{{0}}}", BuildHhlineString(ranges)) : string.Empty;
    }

    private string BuildHhlineString(Dictionary<string, BorderInformation.BorderStyleEnum> ranges)
    {
      string hhlineString = "";

      int i = 1;
      foreach (var range in ranges)
      {
        int from = GetFrom(range.Key);
        int to = GetTo(range.Key);
        char hhlineSym = GetHhlineSymbol(range.Value);

        hhlineString = AddNoneBorderBeforeNextFrom(ref i, @from, hhlineString);
        hhlineString = AddBorderWithinRange(ref i, to, hhlineSym, hhlineString);
      }
      hhlineString = AddNoneBorderToEnd(i, hhlineString);
      return hhlineString;
    }

    private string AddNoneBorderToEnd(int i, string hhlineString)
    {
      return AddNoneBorderBeforeNextFrom(ref i, _columns + 1, hhlineString);
    }

    private int GetFrom(string range)
    {
      string[] values = range.Split('-');
      return Convert.ToInt32(values.First());
    }

    private int GetTo(string range)
    {
      string[] values = range.Split('-');
      return Convert.ToInt32(values.Last());
    }

    private char GetHhlineSymbol(BorderInformation.BorderStyleEnum borderStyle)
    {
      switch (borderStyle)
      {
        case BorderInformation.BorderStyleEnum.None:
          return '~';
        case BorderInformation.BorderStyleEnum.Solid:
          return '-';
        case BorderInformation.BorderStyleEnum.DoubleLineSolid:
          return '=';
      }
      return '-';
    }

    private string AddNoneBorderBeforeNextFrom(ref int i, int @from, string hhlineString)
    {
      while (i < @from)
      {
        hhlineString += GetHhlineSymbol(BorderInformation.BorderStyleEnum.None);
        i++;
      }
      return hhlineString;
    }

    private string AddBorderWithinRange(ref int i, int to, char hhlineSym, string hhlineString)
    {
      while (i <= to)
      {
        hhlineString += hhlineSym;
        i++;
      }
      return hhlineString;
    }
  }
}
