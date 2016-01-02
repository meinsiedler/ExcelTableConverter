using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.LatexTableConverter.BorderStylers
{
  public abstract class HorizontalRuleStyler
  {
    public abstract string GetTopHorizontalRule(Row row);
    public abstract string GetBottomHorizontalRule(Row row);

    protected abstract string GetRuleCommand(Dictionary<string, BorderInformation.BorderStyleEnum> ranges);

    private Dictionary<int, BorderInformation.BorderStyleEnum> GetBorderSet(Row row, Cell.BorderPositionEnum borderPosition)
    {
      Dictionary<int, BorderInformation.BorderStyleEnum> borderIsSet = new Dictionary<int, BorderInformation.BorderStyleEnum>();
      int i = 1;
      foreach (var cell in row.Columns)
      {
        if (BorderIsSetAndNoRangeAdded(cell, borderPosition, borderIsSet) ||
          BorderNotSetAndAndNonEmptyLastCellBorder(cell, borderPosition, borderIsSet) ||
          BorderIsSetAndEmptyLastCellBorder(cell, borderPosition, borderIsSet) ||
          LastBorderDiffersFromActualBorder(cell, borderPosition, borderIsSet))
        {
          borderIsSet.Add(i, cell.Borders[borderPosition].BorderStyle);
        }
        i++;
      }

      return borderIsSet;
    }

    private static bool BorderIsSetAndNoRangeAdded(Cell cell, Cell.BorderPositionEnum borderPosition, Dictionary<int, BorderInformation.BorderStyleEnum> borderIsSet)
    {
      return cell.Borders[borderPosition].BorderStyle != BorderInformation.BorderStyleEnum.None && borderIsSet.Count == 0;
    }

    private static bool BorderNotSetAndAndNonEmptyLastCellBorder(Cell cell, Cell.BorderPositionEnum borderPosition, Dictionary<int, BorderInformation.BorderStyleEnum> borderIsSet)
    {
      return cell.Borders[borderPosition].BorderStyle == BorderInformation.BorderStyleEnum.None && borderIsSet.Count > 0 && borderIsSet.Last().Value != BorderInformation.BorderStyleEnum.None;
    }

    private static bool BorderIsSetAndEmptyLastCellBorder(Cell cell, Cell.BorderPositionEnum borderPosition, Dictionary<int, BorderInformation.BorderStyleEnum> borderIsSet)
    {
      return cell.Borders[borderPosition].BorderStyle != BorderInformation.BorderStyleEnum.None && borderIsSet.Last().Value == BorderInformation.BorderStyleEnum.None;
    }

    private static bool LastBorderDiffersFromActualBorder(Cell cell, Cell.BorderPositionEnum borderPosition,
                                                          Dictionary<int, BorderInformation.BorderStyleEnum> borderIsSet)
    {
      return cell.Borders[borderPosition].BorderStyle != BorderInformation.BorderStyleEnum.None &&
             borderIsSet.Last().Value != cell.Borders[borderPosition].BorderStyle;
    }

    protected Dictionary<string, BorderInformation.BorderStyleEnum> GetRuleRangesFromTo(Row row, Cell.BorderPositionEnum borderPosition)
    {
      var borderIsSet = GetBorderSet(row, borderPosition);
      var columnCount = row.Columns.Count;

      Dictionary<string, BorderInformation.BorderStyleEnum> ranges = new Dictionary<string, BorderInformation.BorderStyleEnum>();
      if (borderIsSet.Count == 1)
      {
        ranges.Add(borderIsSet.First().Key + "-" + columnCount, borderIsSet.First().Value);
        return ranges;
      }

      for (int i = 0; i < borderIsSet.Count; i++)
      {
        if (borderIsSet.ElementAt(i).Value != BorderInformation.BorderStyleEnum.None)
        {
          if (i + 1 < borderIsSet.Count)
            ranges.Add(borderIsSet.ElementAt(i).Key + "-" + (borderIsSet.ElementAt(i + 1).Key - 1), borderIsSet.ElementAt(i).Value);
          else
            ranges.Add(borderIsSet.ElementAt(i).Key + "-" + columnCount, borderIsSet.ElementAt(i).Value);
        }
      }

      return ranges;
    }
  }
}
