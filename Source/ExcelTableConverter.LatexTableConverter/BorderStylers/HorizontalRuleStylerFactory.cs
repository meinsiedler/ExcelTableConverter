using System;
using System.Collections.Generic;
using System.Linq;
using ExcelTableConverter.ExcelContent.Model;
using ExcelTableConverter.Utilities;

namespace ExcelTableConverter.LatexTableConverter.BorderStylers
{
  public static class HorizontalRuleStylerFactory
  {
    public static Dictionary<Row, HorizontalRuleStyler> GetTopHorizontalRuleStyler(Row row)
    {
      return GetHorizontalRuleStyler(row, Cell.BorderPositionEnum.Top);
    }

    public static Dictionary<Row, HorizontalRuleStyler> GetBottomHorizontalRuleStyler(Row row)
    {
      return GetHorizontalRuleStyler(row, Cell.BorderPositionEnum.Bottom);
    }

    private static Dictionary<Row, HorizontalRuleStyler> GetHorizontalRuleStyler(Row row, Cell.BorderPositionEnum borderPosition)
    {
      if (row.Columns.Count > 0)
      {
        var ruleStylers = new Dictionary<Row, HorizontalRuleStyler>();

        var dottedStyles = new[] { BorderInformation.BorderStyleEnum.Dotted };
        var dottedPreparedRow = GetPreparedRow(row.Clone(), borderPosition, dottedStyles);
        if (ContainsBorderStyle(dottedPreparedRow.Columns, borderPosition, dottedStyles))
          ruleStylers.Add(dottedPreparedRow, new DottedRuleStyler());

        var dashedStyles = new[] {BorderInformation.BorderStyleEnum.Dashed};
        var dashedPreparedRow = GetPreparedRow(row.Clone(), borderPosition, dashedStyles);
        if (ContainsBorderStyle(dashedPreparedRow.Columns, borderPosition, dashedStyles))
          ruleStylers.Add(dashedPreparedRow, new DashedRuleStyler());

        var solidStyles = new[]{BorderInformation.BorderStyleEnum.Solid, BorderInformation.BorderStyleEnum.DoubleLineSolid};
        var solidPreparedRow = GetPreparedRow(row.Clone(), borderPosition, solidStyles);
        if (ContainsBorderStyle(solidPreparedRow.Columns, borderPosition, solidStyles))
          ruleStylers.Add(solidPreparedRow, new SolidRuleStyler());
        

        return ruleStylers;
      }

      throw new ArgumentException("specified row has no columns");
    }

    private static Row GetPreparedRow(Row row, Cell.BorderPositionEnum borderPosition, IEnumerable<BorderInformation.BorderStyleEnum> borderStyles)
    {
      foreach (var column in row.Columns)
      {
        if (!column.Borders.ContainsKey(borderPosition))
          column.Borders.Add(borderPosition, new BorderInformation {BorderStyle = BorderInformation.BorderStyleEnum.None});
        

        if(!borderStyles.Contains(column.Borders[borderPosition].BorderStyle))
          column.Borders[borderPosition].BorderStyle = BorderInformation.BorderStyleEnum.None;
      }
      return row;
    }

    private static bool ContainsBorderStyle(IEnumerable<Cell> columns, Cell.BorderPositionEnum borderPosition,
                                            IEnumerable<BorderInformation.BorderStyleEnum> borderStyles)
    {
      return columns.Any(x => borderStyles.Contains(x.Borders[borderPosition].BorderStyle));
    }
  }
}
