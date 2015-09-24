using System;
using System.Collections.Generic;
using System.Drawing;
using ExcelTableConverter.ExcelContent.Model;

namespace ExcelTableConverter.TestsCommon
{
  public class Constants
  {
    public static Table GetSimpleTable()
    {
      int maxColumns = 5;
      int maxRows = 4;

      var table = new Table("simple table", maxColumns, maxRows);

      for (int i = 0; i < maxRows; i++)
      {
        for (int j = 0; j < maxColumns; j++)
        {
          table.Rows[i].Columns[j] = new Cell
          {
            Text = (i + 1).ToString() + " " + (j + 1).ToString(),
            TextEmphasis = new List<Cell.EmphasisEnum>(),
            TextColor = Color.Black, FillColor = Color.White,
            Borders = new Dictionary<Cell.BorderPositionEnum, BorderInformation>()
          };
        }
      }

      return table;
    }

    public static Table GetTableWithAllFeatures()
    {
      var table = GetSimpleTable();
      table.Rows[0].Columns[0].Text = "1";              // number (justify right)
      table.Rows[0].Columns[1].Text = "20%";           // special char
      table.Rows[0].Columns[2].FillColor = Color.Aqua;  // fill color
      table.Rows[0].Columns[3].TextColor = Color.Red;   // text color
      table.Rows[0].Columns[4].FillColor = Color.Aqua;  // fill color ...
      table.Rows[0].Columns[4].TextColor = Color.Red;   // ... and text color

      // add some BorderInformation for FullBorderConfig
      table.Rows[0].Columns[0].Borders.Add(Cell.BorderPositionEnum.Top,
        new BorderInformation {BorderStyle = BorderInformation.BorderStyleEnum.Dashed, Thickness = BorderInformation.ThicknessEnum.Hairline});

      table.Rows[0].Columns[0].Borders.Add(Cell.BorderPositionEnum.Bottom,
        new BorderInformation { BorderStyle = BorderInformation.BorderStyleEnum.Dotted, Thickness = BorderInformation.ThicknessEnum.Medium });

      return table;
    }
  }
}
