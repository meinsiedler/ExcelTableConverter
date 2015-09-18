using System;
using System.Collections.Generic;
using System.Drawing;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.TestsCommon
{
  public class Constants
  {
    private static Table s_simpleTable;

    public static Table GetSimpleTable()
    {
      if(s_simpleTable == null)
        InitSimpleTable();
      return s_simpleTable;
    }

    private static void InitSimpleTable()
    {
      int maxColumns = 5;
      int maxRows = 4;

      s_simpleTable = new Table("simple table", maxColumns, maxRows);

      for (int i = 0; i < maxRows; i++)
      {
        for (int j = 0; j < maxColumns; j++)
        {
          s_simpleTable.Rows[i].Columns[j] = new Cell
          {
            Text = (i + 1).ToString() + " " + (j + 1).ToString(),
            TextEmphasis = new List<Cell.EmphasisEnum>(),
            TextColor = Color.Black, FillColor = Color.White,
          };
        }
      }
    }
  }
}
